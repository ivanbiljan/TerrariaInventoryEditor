using System;
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
        private const string EncryptionString = "h3y_gUyZ";
        private const int CurrentRelease = 234;
        
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

            var golfTimestamp = DateTime.UtcNow.ToBinary();
            writer.Write(golfTimestamp);
            writer.Write(player.GolferScoreAccumulated);
            writer.Write(0); // TODO: creative tracker
            writer.Write(0); // TODO: temporary item slot contents
            writer.Write(false); // TODO: creative powers
        }
    }
}