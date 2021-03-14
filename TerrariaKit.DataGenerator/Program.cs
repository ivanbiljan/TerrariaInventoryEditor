using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Win32;

namespace TerrariaKit.DataGenerator
{
    class Program
    {
        private const string TerrariaRegistrySubKeyPath =
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 105600";

        private static Assembly _terrariaAssembly;

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;
            
            using var localMachineHiveKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
            using var terrariaKey = localMachineHiveKey.OpenSubKey(TerrariaRegistrySubKeyPath);
            if (terrariaKey is null)
            {
                Console.WriteLine("Could not find Terraria install location.");
                return;
            }

            var terrariaExePath = Path.Combine((string) terrariaKey.GetValue("InstallLocation"), "Terraria.exe");
            if (string.IsNullOrWhiteSpace(terrariaExePath))
            {
                Console.WriteLine("Could not find Terraria.exe");
                return;
            }

            // Reflection is slow but it also means that we can generate the data without user intervention
            _terrariaAssembly = Assembly.LoadFrom(terrariaExePath);

            _terrariaAssembly.GetType("Terraria.Lang")!.GetMethod("InitializeLegacyLocalization")!.Invoke(null, null);

            var itemType = _terrariaAssembly.GetType("Terraria.Item");
            var item = Activator.CreateInstance(itemType!);
            var maxItemTypes = (int)_terrariaAssembly.GetType("Terraria.Main")!.GetField("maxItemTypes")!.GetValue(null)!;
            for (var i = 0; i < maxItemTypes; ++i)
            {
                // Familiar clothing vanity hack
                if (i >= 269 && i <= 271)
                {
                    continue;
                }
                
                itemType.GetMethod("SetDefaults", new []{typeof(int)})!.Invoke(item, new object[] {i});
                var json = JsonSerializer.Serialize(new
                {
                    netId = itemType.GetField("netID")!.GetValue(item),
                    name = itemType.GetProperty("Name")!.GetValue(item)
                });

                Console.WriteLine(json);
            }
        }

        private static Assembly? CurrentDomainOnAssemblyResolve(object? sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            var assembly = AppDomain.CurrentDomain.GetAssemblies()
                                    .FirstOrDefault(a => a.GetName().Name == assemblyName.Name);
            if (assembly != null)
            {
                return assembly;
            }

            var resource = _terrariaAssembly.GetManifestResourceNames()
                                            .FirstOrDefault(r => r.EndsWith(assemblyName.Name + ".dll"));
            if (resource == null)
            {
                return null;
            }

            using var stream = _terrariaAssembly.GetManifestResourceStream(resource);
            var buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            return Assembly.Load(buffer);
        }
    }
}