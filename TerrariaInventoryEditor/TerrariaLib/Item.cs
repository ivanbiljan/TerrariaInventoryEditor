using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using TerrariaInventoryEditor.Framework;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents a Terraria Item.
    /// </summary>
    public sealed class Item : DataSourceObject
    {
        /// <summary>
        ///     Gets or sets the item's ammo type.
        /// </summary>
        [JsonProperty("ammo_type")]
        public int AmmoType
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's animation style.
        /// </summary>
        [JsonProperty("animation_style")]
        public ItemAnimationStyle AnimationStyle
        {
            get => Get<ItemAnimationStyle>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's animation time.
        /// </summary>
        [JsonProperty("animation_time")]
        public int AnimationTime
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's axe power.
        /// </summary>
        [JsonProperty("axe_power")]
        public int AxePower
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's bait power.
        /// </summary>
        [JsonProperty("bait_power")]
        public int BaitPower
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's body slot.
        /// </summary>
        [JsonProperty("body_slot")]
        public int BodySlot
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's colour.
        /// </summary>
        [JsonProperty("color")]
        public Color Color
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's damage.
        /// </summary>
        [JsonProperty("damage")]
        public int Damage
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets  the item's fishing power.
        /// </summary>
        [JsonProperty("fishing_power")]
        public int FishingPower
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's hammer power.
        /// </summary>
        [JsonProperty("hammer_power")]
        public int HammerPower
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's head slot.
        /// </summary>
        [JsonProperty("head_slot")]
        public int HeadSlot
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's height.
        /// </summary>
        [JsonProperty("height")]
        public int Height
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's texture.
        /// </summary>
        public Bitmap Image
        {
            get
            {
                try
                {
                    return new Bitmap($"Data\\ItemTextures\\Item_{NetId}.png");
                }
                catch (ArgumentException)
                {
                    return new Bitmap("Data\\ItemTextures\\Item_0.png");
                }
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is an accessory.
        /// </summary>
        [JsonProperty("is_accessory")]
        public bool IsAccessory
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether this item is auto reuse.
        /// </summary>
        [JsonProperty("is_auto_reuse")]
        public bool IsAutoReuse
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is favourited.
        /// </summary>
        public bool IsFavourite
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is a 'magic' weapon.
        /// </summary>
        [JsonProperty("is_magic_weapon")]
        public bool IsMagic
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is a 'meele' weapon.
        /// </summary>
        [JsonProperty("is_meele_weapon")]
        public bool IsMeele
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is a 'ranged' weapon.
        /// </summary>
        [JsonProperty("is_ranged_weapon")]
        public bool IsRanged
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the item is a 'thrown' weapon.
        /// </summary>
        [JsonProperty("is_thrown_weapon")]
        public bool IsThrown
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's knockback.
        /// </summary>
        [JsonProperty("knockback")]
        public float Knockback
        {
            get => Get<float>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or set sthe item's leg slot.
        /// </summary>
        [JsonProperty("leg_slot")]
        public int LegSlot
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's mana cost.
        /// </summary>
        [JsonProperty("mana_cost")]
        public int ManaCost
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's max stack size.
        /// </summary>
        [JsonProperty("max_stack")]
        public int MaxStack
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => Get<string>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's Net ID.
        /// </summary>
        [JsonProperty("net_id")]
        public int NetId
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's pickaxe power.
        /// </summary>
        [JsonProperty("pickaxe_power")]
        public int PickaxePower
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's prefix.
        /// </summary>
        [JsonProperty("prefix")]
        public ItemPrefix Prefix
        {
            get => Get<ItemPrefix>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's projectile speed.
        /// </summary>
        [JsonProperty("projectile_speed")]
        public float ProjectileSpeed
        {
            get => Get<float>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's projectile type.
        /// </summary>
        [JsonProperty("projectile_type")]
        public ProjectileType ProjectileType
        {
            get => Get<ProjectileType>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's rarity.
        /// </summary>
        [JsonProperty("rarity")]
        public ItemRarity Rarity
        {
            get => Get<ItemRarity>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's graphics scale.
        /// </summary>
        [JsonProperty("scale")]
        public float Scale
        {
            get => Get<float>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's slot index.
        /// </summary>
        public int SlotIndex
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the item's stack size.
        /// </summary>
        [JsonProperty("stack_size")]
        public int StackSize
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's use ammo.
        /// </summary>
        [JsonProperty("use_ammo")]
        public int UseAmmo
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's use time.
        /// </summary>
        [JsonProperty("use_time")]
        public int UseTime
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the item's width.
        /// </summary>
        [JsonProperty("width")]
        public int Width
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Constructs the item based on the specified net ID.
        /// </summary>
        /// <param name="netId">The net ID.</param>
        public void SetDefaults(int netId)
        {
            Debug.Assert(netId >= 0, "NetId must not be negative.");
            Debug.Assert(netId < Terraria.Instance.Items.Count,
                "NetId must not be greater than the size of item collection.");

            var item = Terraria.Instance.Items.SingleOrDefault(i => i.NetId == netId);
            if (item == null)
            {
                return;
            }

            AmmoType = item.AmmoType;
            AnimationStyle = item.AnimationStyle;
            AnimationTime = item.AnimationTime;
            AxePower = item.AxePower;
            BaitPower = item.BaitPower;
            BodySlot = item.BodySlot;
            Color = item.Color;
            Damage = item.Damage;
            FishingPower = item.FishingPower;
            HammerPower = item.HammerPower;
            HeadSlot = item.HeadSlot;
            Height = item.Height;
            IsAccessory = item.IsAccessory;
            IsAutoReuse = item.IsAutoReuse;
            IsMagic = item.IsMagic;
            IsMeele = item.IsMeele;
            IsRanged = item.IsRanged;
            IsThrown = item.IsThrown;
            Knockback = item.Knockback;
            LegSlot = item.LegSlot;
            ManaCost = item.ManaCost;
            MaxStack = item.MaxStack;
            Name = item.Name;
            NetId = item.NetId;
            PickaxePower = item.PickaxePower;
            Prefix = item.Prefix;
            ProjectileSpeed = item.ProjectileSpeed;
            ProjectileType = item.ProjectileType;
            Rarity = item.Rarity;
            Scale = item.Scale;
            StackSize = item.StackSize;
            UseAmmo = item.UseAmmo;
            UseTime = item.UseTime;
            Width = item.Width;
        }

        /// <summary>
        /// Returns the string representation of this item.
        /// </summary>
        /// <returns>The string representation of this item.</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}