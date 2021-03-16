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
    }
}