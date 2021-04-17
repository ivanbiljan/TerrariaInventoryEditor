using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TerrariaKit.Core.Extensions;
using TerrariaKit.Core.Models;

namespace TerrariaKit.Services
{
    internal sealed class PlayerFileService
    {
        // TODO: cloud saves
        // TODO: Dpad radial bindings
        // TODO: creative tracker
        // TODO: temporary item slot saves
        // TODO: creative powers
        // TODO: older release backwards compatibility
        
        private const string EncryptionString = "h3y_gUyZ";
        private const int CurrentRelease = 234;

        private readonly LocalizationService _localizationService;
        
        public PlayerFileService(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }
        
        public void Save(PlayerFile playerFile)
        {
            if (File.Exists(playerFile.Path))
            {
                File.Copy(playerFile.Path, $"{playerFile.Path}.bak", true);
            }

            using var rijndael = new RijndaelManaged();

            var encryptionKey = new UnicodeEncoding().GetBytes(EncryptionString);
            var encryptor = rijndael.CreateEncryptor(encryptionKey, encryptionKey);
            using var stream = new CryptoStream(new FileStream(playerFile.Path, FileMode.Create), encryptor,
                CryptoStreamMode.Write);
            using var writer = new BinaryWriter(stream);

            var player = playerFile.Data;
            writer.Write(CurrentRelease);
            playerFile.WriteMetadata(writer);
            writer.Write(player.Name);
            writer.Write((byte) player.Difficulty);
            writer.Write(player.PlayTime.Ticks);
            writer.Write(player.Hair);
            writer.Write(player.HairDye);

            var accessoryHiddenFlags = default(Flags);
            for (var i = 0; i < 8; ++i)
            {
                accessoryHiddenFlags[i] = player.IsAccessoryHidden[i];
            }

            writer.Write(Unsafe.As<Flags, byte>(ref accessoryHiddenFlags));

            var accessoryHiddenFlags2 = default(Flags);
            for (var i = 0; i < player.IsAccessoryHidden.Length - 8; ++i)
            {
                accessoryHiddenFlags2[i] = player.IsAccessoryHidden[i + 8];
            }

            writer.Write(Unsafe.As<Flags, byte>(ref accessoryHiddenFlags2));
            
            writer.Write(player.HideMisc);
            writer.Write(player.SkinVariant);
            writer.Write(player.Health);
            writer.Write(player.MaxHealth);
            writer.Write(player.Mana);
            writer.Write(player.MaxMana);
            writer.Write(player.HasExtraAccessoryEnabled);
            writer.Write(player.HasUnlockedTorchGodsReward);
            writer.Write(player.IsUsingBiomeTorches);
            writer.Write(player.HasCompletedDD2Event);
            writer.Write(player.TaxMoney);
            writer.Write(player.HairColor);
            writer.Write(player.SkinColor);
            writer.Write(player.EyeColor);
            writer.Write(player.ShirtColor);
            writer.Write(player.UndershirtColor);
            writer.Write(player.PantsColor);
            writer.Write(player.ShoeColor);

            foreach (var item in player.Armor)
            {
                writer.Write(item.NetId);
                writer.Write(item.Prefix);
            }

            foreach (var item in player.Dye)
            {
                writer.Write(item.NetId);
                writer.Write(item.Prefix);
            }

            foreach (var item in player.Inventory) {
                writer.Write(item.NetId);
                writer.Write(item.StackSize);
                writer.Write(item.Prefix);
                writer.Write(item.IsFavorite);
            }

            for (var i = 0; i < player.MiscellaneousEquips.Length; ++i)
            {
                writer.Write(player.MiscellaneousEquips[i].NetId);
                writer.Write(player.MiscellaneousEquips[i].Prefix);

                writer.Write(player.MiscellaneousDye[i].NetId);
                writer.Write(player.MiscellaneousDye[i].Prefix);
            }

            for (var i = 0; i < player.Bank.Length; ++i)
            {
                writer.Write(player.Bank[i].NetId);
                writer.Write(player.Bank[i].StackSize);
                writer.Write(player.Bank[i].Prefix);
            }

            for (var i = 0; i < player.Bank2.Length; ++i)
            {
                writer.Write(player.Bank2[i].NetId);
                writer.Write(player.Bank2[i].StackSize);
                writer.Write(player.Bank2[i].Prefix);
            }

            for (var i = 0; i < player.Bank3.Length; ++i)
            {
                writer.Write(player.Bank3[i].NetId);
                writer.Write(player.Bank3[i].StackSize);
                writer.Write(player.Bank3[i].Prefix);
            }

            for (var i = 0; i < player.Bank4.Length; ++i)
            {
                writer.Write(player.Bank4[i].NetId);
                writer.Write(player.Bank4[i].StackSize);
                writer.Write(player.Bank4[i].Prefix);
            }
            
            writer.Write(player.VoidVaultInformation);

            foreach (var buff in player.Buffs)
            {
                writer.Write(buff.BuffType);
                writer.Write(buff.BuffTime);
            }

            foreach (var spawn in player.Spawns)
            {
                if (spawn == null)
                {
                    writer.Write(-1);
                    break;
                }
                
                writer.Write(spawn.SpawnX);
                writer.Write(spawn.SpawnY);
                writer.Write(spawn.WorldId);
                writer.Write(spawn.WorldName);
            }
            
            writer.Write(player.IsHotbarLocked);
            foreach (var item in player.HideInfo)
            {
                writer.Write(item);
            }
            
            writer.Write(player.NumberOfAnglerQuestsFinished);

            for (var i = 0; i < 4; ++i) // TODO: Dpad radial bindings
            {
                writer.Write(0);
            }

            for (var i = 0; i < player.BuilderAccessoriesStatuses.Length; ++i)
            {
                writer.Write(player.BuilderAccessoriesStatuses[i]);
            }
            
            writer.Write(player.BartenderQuestLog);
            writer.Write(player.IsDead);
            if (player.IsDead)
            {
                writer.Write(player.RespawnTimer);
            }

            var saveTimestamp = DateTime.UtcNow.ToBinary();
            writer.Write(saveTimestamp);
            writer.Write(player.GolferScoreAccumulated);
            writer.Write(0); // TODO: creative tracker
            writer.Write(0); // TODO: temporary item slot contents
            writer.Write(false); // TODO: creative powers
        }

        public PlayerFile Read(string path)
        {
            var player = new Character();
            var playerFile = new PlayerFile(path) {Data = player};

            using var rijndael = new RijndaelManaged {Padding = PaddingMode.None};
            var decryptionKey = new UnicodeEncoding().GetBytes(EncryptionString);
            using var decryptor = rijndael.CreateDecryptor(decryptionKey, decryptionKey);
            using var stream = new CryptoStream(new MemoryStream(File.ReadAllBytes(path)), decryptor,
                CryptoStreamMode.Read);
            using var reader = new BinaryReader(stream);

            var release = reader.ReadInt32();
            playerFile.ReadMetadata(reader);
            player.Name = reader.ReadString();
            player.Difficulty = (CharacterDifficulty) reader.ReadByte();
            player.PlayTime = new TimeSpan(reader.ReadInt64());
            player.Hair = reader.ReadInt32();
            player.HairDye = reader.ReadByte();

            var flags = (Flags) reader.ReadByte();
            for (var i = 0; i < 8; ++i)
            {
                player.IsAccessoryHidden[i] = flags[i];
            }

            var flags2 = (Flags) reader.ReadByte();
            for (var i = 0; i < player.IsAccessoryHidden.Length - 8; ++i)
            {
                player.IsAccessoryHidden[i + 8] = flags2[i];
            }

            player.HideMisc = reader.ReadByte();
            player.SkinVariant = reader.ReadByte();
            player.Health = reader.ReadInt32();
            player.MaxHealth = reader.ReadInt32();
            player.Mana = reader.ReadInt32();
            player.MaxMana = reader.ReadInt32();
            player.HasExtraAccessoryEnabled = reader.ReadBoolean();
            player.HasUnlockedTorchGodsReward = reader.ReadBoolean();
            player.IsUsingBiomeTorches = reader.ReadBoolean();
            player.HasCompletedDD2Event = reader.ReadBoolean();
            player.TaxMoney = reader.ReadInt32();
            player.HairColor = reader.ReadRgb();
            player.SkinColor = reader.ReadRgb();
            player.EyeColor = reader.ReadRgb();
            player.ShirtColor = reader.ReadRgb();
            player.UndershirtColor = reader.ReadRgb();
            player.PantsColor = reader.ReadRgb();
            player.ShoeColor = reader.ReadRgb();

            for (var i = 0; i < player.Armor.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Armor[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Dye.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Dye[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Inventory.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Inventory[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    StackSize = reader.ReadInt32(),
                    Prefix = reader.ReadByte(),
                    IsFavorite = reader.ReadBoolean()
                };
            }

            for (var i = 0; i < player.MiscellaneousEquips.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.MiscellaneousEquips[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Bank.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Bank[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    StackSize = reader.ReadInt32(),
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Bank2.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Bank2[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    StackSize = reader.ReadInt32(),
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Bank3.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Bank3[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    StackSize = reader.ReadInt32(),
                    Prefix = reader.ReadByte()
                };
            }

            for (var i = 0; i < player.Bank4.Length; ++i)
            {
                var netId = reader.ReadInt32();
                player.Bank4[i] = new Item(netId, _localizationService.GetItemName(netId))
                {
                    StackSize = reader.ReadInt32(),
                    Prefix = reader.ReadByte()
                };
            }

            player.VoidVaultInformation = (Flags) reader.ReadByte();

            for (var i = 0; i < player.Buffs.Length; ++i)
            {
                player.Buffs[i] = new Buff(reader.ReadInt32(), reader.ReadInt32());
            }

            for (var i = 0; i < player.Spawns.Length; ++i)
            {
                var spawnX = reader.ReadInt32();
                if (spawnX == 0)
                {
                    break;
                }

                var spawnY = reader.ReadInt32();
                var worldId = reader.ReadInt32();
                var worldName = reader.ReadString();
                player.Spawns[i] = new SpawnInfo(worldId, worldName, spawnX, spawnY);
            }

            player.IsHotbarLocked = reader.ReadBoolean();

            for (var i = 0; i < player.HideInfo.Length; ++i)
            {
                player.HideInfo[i] = reader.ReadBoolean();
            }

            player.NumberOfAnglerQuestsFinished = reader.ReadInt32();

            for (var i = 0; i < 4; ++i)
            reader.ReadInt32(); // Dpad radial bindings

            for (var i = 0; i < player.BuilderAccessoriesStatuses.Length; ++i)
            {
                player.BuilderAccessoriesStatuses[i] = reader.ReadBoolean();
            }

            player.BartenderQuestLog = reader.ReadInt32();
            if (player.IsDead = reader.ReadBoolean())
            {
                player.RespawnTimer = reader.ReadInt32();
            }

            player.LastSave = DateTime.FromBinary(reader.ReadInt64());
            player.GolferScoreAccumulated = reader.ReadInt32();

            reader.ReadInt32(); // Creative tracker
            reader.ReadInt32(); // Temporary item slot
            reader.ReadBoolean(); // Creative powers

            return playerFile;
        }
    }
}