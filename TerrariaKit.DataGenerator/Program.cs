using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Win32;
using TerrariaKit.Core.Models;

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

            GenerateLocalizationMappings();

            _terrariaAssembly.GetType("Terraria.Lang")!.GetMethod("InitializeLegacyLocalization")!.Invoke(null, null);

            var itemType = _terrariaAssembly.GetType("Terraria.Item");
            var item = Activator.CreateInstance(itemType!);
            var maxItemTypes = (int)_terrariaAssembly.GetType("Terraria.Main")!.GetField("maxItemTypes")!.GetValue(null)!;

            var languageGetTextMethod =
                _terrariaAssembly.GetType("Terraria.Localization.Language")!.GetMethod("GetTextValue",
                    new[] {typeof(string)});

            var items = new List<Item>();
            for (var i = 0; i < maxItemTypes; ++i)
            {
                // Familiar clothing vanity hack
                if (i >= 269 && i <= 271)
                {
                    continue;
                }
                
                itemType.GetMethod("SetDefaults", new []{typeof(int)})!.Invoke(item, new object[] {i});

                var currentItem = new Item(
                    (int) itemType.GetField("netID")!.GetValue(item),
                    (string) languageGetTextMethod.Invoke(null, new[] {itemType.GetProperty("Name")!.GetValue(item)}));

                items.Add(currentItem);
            }

            Console.WriteLine(JsonSerializer.Serialize(items, new JsonSerializerOptions {WriteIndented = true}));
        }

        private static void GenerateLocalizationMappings() 
        {
            var localizationMapping = new Dictionary<string, string>();

            var localizationFileNames = _terrariaAssembly.GetManifestResourceNames()
                                                         .Where(r =>
                                                             r.StartsWith("Terraria.Localization.Content.en-US") &&
                                                             r.EndsWith(".json"));

            var serializerOptions = new JsonSerializerOptions {
                AllowTrailingCommas = true,
                WriteIndented = true
            };

            foreach (var localizationFilePath in localizationFileNames) {
                string fileContents = null;
                using (var manifestStream = _terrariaAssembly.GetManifestResourceStream(localizationFilePath))
                using (var reader = new StreamReader(manifestStream)) {
                    fileContents = reader.ReadToEnd();
                }

                if (string.IsNullOrWhiteSpace(fileContents)) {
                    Console.WriteLine($"Invalid stream at path: {localizationFilePath}");
                    continue;
                }

                var categoriesMap =
                    JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(fileContents,
                        serializerOptions);
                foreach (var category in categoriesMap) {
                    foreach (var kvp in category.Value) {
                        localizationMapping[$"{category.Key}.{kvp.Key}"] = kvp.Value;
                    }
                }
            }

            Console.WriteLine(JsonSerializer.Serialize(localizationMapping, serializerOptions));
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