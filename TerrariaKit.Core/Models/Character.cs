using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TerrariaKit.Core.Models
{
    /// <summary>
    /// Represents a Terraria character.
    /// </summary>
    public sealed class Character
    {
        // TODO: Strip out members irrelevant to the console client. This class should only contain data common to the inventory editor and the console client
        public string Name { get; set; }
        
        public CharacterDifficulty Difficulty { get; set; }
        
        public TimeSpan PlayTime { get; set; }
        
        public int Hair { get; set; }
        
        public byte HairDye { get; set; }

        public bool[] IsAccessoryHidden { get; } = new bool[10];
        
        public byte HideMisc { get; set; }

        public byte SkinVariant { get; set; }
        
        public int Health { get; set; }
        
        public int MaxHealth { get; set; }
        
        public int Mana { get; set; }
        
        public int MaxMana { get; set; }
        
        public bool HasExtraAccessoryEnabled { get; set; }
        
        public bool HasUnlockedTorchGodsReward { get; set; }
        
        public bool IsUsingBiomeTorches { get; set; }
        
        public bool HasCompletedDD2Event { get; set; }
        
        public int TaxMoney { get; set; }
        
        public Color HairColor { get; set; }
        
        public Color SkinColor { get; set; }
        
        public Color EyeColor { get; set; }
        
        public Color ShirtColor { get; set; }
        
        public Color UndershirtColor { get; set; }
        
        public Color PantsColor { get; set; }
        
        public Color ShoeColor { get; set; }

        public Item[] Armor { get; } = new Item[20];

        public Item[] Dye { get; } = new Item[10];

        public Item[] Inventory { get; } = new Item[58];

        public Item[] MiscellaneousEquips { get; } = new Item[5];

        public Item[] MiscellaneousDye { get; } = new Item[5];

        public Item[] Bank { get; } = new Item[40];

        public Item[] Bank2 { get; } = new Item[40];

        public Item[] Bank3 { get; } = new Item[40];

        public Item[] Bank4 { get; } = new Item[40];
        
        public Flags VoidVaultInformation { get; set; }

        public Buff[] Buffs { get; } = new Buff[22];

        public SpawnInfo[] Spawns { get; } = new SpawnInfo[200];
        
        public bool IsHotbarLocked { get; set; }

        public bool[] HideInfo { get; } = new bool[7];
        
        public int NumberOfAnglerQuestsFinished { get; set; }

        public bool[] BuilderAccessoriesStatuses { get; } = new bool[12];
        
        public int BartenderQuestLog { get; set; }
        
        public bool IsDead { get; set; }
        
        public int RespawnTimer { get; set; }
        
        public DateTime LastSave { get; set; }
        
        public int GolferScoreAccumulated { get; set; }
    }
}