using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TerrariaInventoryEditor.Extensions;

namespace TerrariaInventoryEditor.Terraria
{
    public delegate void PlayerLoadedD();

    public delegate void PlayerSavedD();

    /// <summary>
    ///     Represents a Terraria Player.
    /// </summary>
    // TODO: Implement older version support
    // TODO: Hide misc implementation
    // TODO: Downed DD2 implementation
    // TODO: Spawn points implementation
    // TODO: Hide info implementation
    public sealed class Player
    {
        /// <summary>
        ///     Gets the encryption key used to encrypt and decrypt player profiles.
        /// </summary>
        private const string EncryptionKey = "h3y_gUyZ";

        /// <summary>
        ///     Gets the magic number used for ReLogic's special logic for files.
        /// </summary>
        private const ulong MagicNumber = 27981915666277746;

        /// <summary>
        ///     TODO
        /// </summary>
        public bool[] HideVisuals = new bool[10];

        /// <summary>
        ///     Initializes a new instance of the <see cref="Player" /> class with some preset values.
        /// </summary>
        public Player()
        {
            Name = "Player name";
            Difficulty = PlayerDifficulty.Softcore;
            SkinVariant = 1;
            Health = 100;
            MaxHealth = 100;
            Mana = 20;
            MaxMana = 20;

            for (var i = 0; i < Buffs.Length; ++i)
            {
                Buffs[i] = new Buff();
            }

            for (var i = 0; i < Inventory.Length; ++i)
            {
                if (i < Armor.Length)
                {
                    Armor[i] = new Item();
                }

                Inventory[i] = new Item();
            }

            for (var i = 0; i < Dye.Length; ++i)
            {
                Dye[i] = new Item();
            }

            for (var i = 0; i < MiscEquips.Length; ++i)
            {
                MiscEquips[i] = new Item();
                MiscDye[i] = new Item();
            }

            for (var i = 0; i < PiggyBank.Length; ++i)
            {
                PiggyBank[i] = new Item();
                Safe[i] = new Item();
                Forge[i] = new Item();
            }
        }

        /// <summary>
        ///     Gets or sets the number of angler quests the player has finished.
        /// </summary>
        public int AnglerQuestsFinished { get; set; }

        /// <summary>
        ///     Gets the player's armor.
        ///     Order: 0-2 = Armor, 3-9 = Accessories (1 extra + 1 hidden), 10-12 Social Armor, 13-19 Social Accessories.
        /// </summary>
        public Item[] Armor { get; } = new Item[20];

        /// <summary>
        ///     Gets the player's buffs.
        /// </summary>
        public Buff[] Buffs { get; } = new Buff[22];

        /// <summary>
        ///     Gets the status of building accessories.
        /// </summary>
        public int[] BuildAccessorieStatus { get; } = new int[10];

        /// <summary>
        ///     Gets or sets the player's difficulty.
        /// </summary>
        public PlayerDifficulty Difficulty { get; set; }

        /// <summary>
        ///     Gets the player's dye.
        ///     Order: 0-2 = Armor, 3-9 = Accessories (1 extra + 1 hidden).
        /// </summary>
        public Item[] Dye { get; } = new Item[10];

        /// <summary>
        ///     Gets or sets a value indicating whether the player has an extra accessory slot available.
        /// </summary>
        public bool ExtraAccessory { get; set; }

        /// <summary>
        ///     Gets or sets the player's eye colour.
        /// </summary>
        public Color EyeColor { get; set; }

        /// <summary>
        ///     Gets the path to the player's storage file.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        ///     Gets the player's forge.
        /// </summary>
        public Item[] Forge { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's hair.
        /// </summary>
        public int Hair { get; set; }

        /// <summary>
        ///     Gets or sets the player's hair colour.
        /// </summary>
        public Color HairColor { get; set; }

        /// <summary>
        ///     Gets or sets the player's hair dye.
        /// </summary>
        public byte HairDye { get; set; }

        /// <summary>
        ///     Gets or sets the player's current health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        ///     Gets the player's inventory.
        /// </summary>
        public Item[] Inventory { get; } = new Item[58];

        /// <summary>
        ///     Gets or sets a value indicating whether the player is favourited.
        /// </summary>
        public bool IsFavourite { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the player's hotbar has been locked.
        /// </summary>
        public bool IsHotbarLocked { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether the player is male.
        /// </summary>
        [Obsolete("Use Player.SkinVariant instead.")]
        public bool IsMale { get; set; }

        /// <summary>
        ///     Get or sets the player's max health.
        /// </summary>
        public int MaxHealth { get; set; }

        /// <summary>
        ///     Gets or sets the player's max mana.
        /// </summary>
        public int MaxMana { get; set; }

        /// <summary>
        ///     Gets or sets the player's current mana.
        /// </summary>
        public int Mana { get; set; }

        /// <summary>
        ///     Gets the player's misc dyes.
        /// </summary>
        public Item[] MiscDye { get; } = new Item[5];

        /// <summary>
        ///     Gets the player's misc equips.
        /// </summary>
        public Item[] MiscEquips { get; } = new Item[5];

        /// <summary>
        ///     Gets or sets the player's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the player's pants colour.
        /// </summary>
        public Color PantsColor { get; set; }

        /// <summary>
        ///     Gets the player's piggy bank.
        /// </summary>
        public Item[] PiggyBank { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's play time.
        /// </summary>
        public TimeSpan PlayTime { get; set; }

        /// <summary>
        ///     Gets or sets the release number.
        /// </summary>
        public int Release { get; set; }

        /// <summary>
        ///     Gets or sets the revision.
        /// </summary>
        public uint Revision { get; set; }

        /// <summary>
        ///     Gets the player's safe.
        /// </summary>
        public Item[] Safe { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's shirt colour.
        /// </summary>
        public Color ShirtColor { get; set; }

        /// <summary>
        ///     Gets or sets the player's shoe colour.
        /// </summary>
        public Color ShoeColor { get; set; }

        /// <summary>
        ///     Gets or sets the player's skin colour.
        /// </summary>
        public Color SkinColor { get; set; }

        /// <summary>
        ///     Gets or sets the player's skin variant. Used to determine the player's gender.
        /// </summary>
        public int SkinVariant { get; set; }

        /// <summary>
        ///     Gets or sets the player's tax money.
        /// </summary>
        public int TaxMoney { get; set; }

        /// <summary>
        ///     Gets or sets the player's undershirt colour.
        /// </summary>
        public Color UndershirtColor { get; set; }

        /// <summary>
        ///     Occurs when a player profile is loaded.
        /// </summary>
        public static event PlayerLoadedD PlayerLoaded;

        /// <summary>
        ///     Occurs when a player profile is saved.
        /// </summary>
        public static event PlayerSavedD PlayerSaved;

        /// <summary>
        ///     Loads a player profile from the given path.
        /// </summary>
        /// <param name="playerPath">The path.</param>
        public void Load(string playerPath)
        {
            if (string.IsNullOrWhiteSpace(playerPath))
            {
                return;
            }

            FilePath = playerPath;
            using (var rijndaelManaged = new RijndaelManaged {Padding = PaddingMode.None})
            using (var memoryStream = new MemoryStream(File.ReadAllBytes(playerPath)))
            {
                var bytes = new UnicodeEncoding().GetBytes(EncryptionKey);
                using (var cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(bytes, bytes),
                    CryptoStreamMode.Read))
                using (var reader = new BinaryReader(cryptoStream))
                {
                    var releaseNumber = reader.ReadInt32();
                    if (releaseNumber != Terraria.CurrentRelease)
                    {
                        throw new Exception("Unsupported Terraria version.");
                    }

                    var magicNumber = reader.ReadUInt64();
                    if ((magicNumber & 72057594037927935) != MagicNumber)
                    {
                        throw new Exception("Expected ReLogic file format.");
                    }

                    var fileType = (byte) ((magicNumber >> 56) & byte.MaxValue);
                    if (fileType != 3)
                    {
                        throw new Exception("Expected Player file type.");
                    }

                    Revision = reader.ReadUInt32();
                    IsFavourite = (reader.ReadUInt64() & 1L) == 1L;

                    Name = reader.ReadString();
                    Difficulty = (PlayerDifficulty) reader.ReadByte();
                    PlayTime = new TimeSpan(reader.ReadInt64());
                    Hair = reader.ReadInt32();
                    HairDye = reader.ReadByte();

                    var visuals = reader.ReadByte();
                    for (var i = 0; i < 8; ++i)
                    {
                        HideVisuals[i] = visuals.ReadBit(i);
                    }
                    for (var i = 0; i < 2; ++i)
                    {
                        HideVisuals[i + 8] = visuals.ReadBit(i);
                    }

                    reader.ReadBytes(2); // TODO (Hide misc)
                    SkinVariant = reader.ReadByte();
                    Health = reader.ReadInt32();
                    MaxHealth = reader.ReadInt32();
                    Mana = reader.ReadInt32();
                    MaxMana = reader.ReadInt32();
                    ExtraAccessory = reader.ReadBoolean();
                    reader.ReadBoolean(); // TODO (Downed DD2)
                    TaxMoney = reader.ReadInt32();
                    HairColor = reader.ReadColor();
                    SkinColor = reader.ReadColor();
                    EyeColor = reader.ReadColor();
                    ShirtColor = reader.ReadColor();
                    UndershirtColor = reader.ReadColor();
                    PantsColor = reader.ReadColor();
                    ShoeColor = reader.ReadColor();

                    for (var i = 0; i < Armor.Length; ++i)
                    {
                        Armor[i].SetDefaults(reader.ReadInt32());
                        Armor[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < Dye.Length; ++i)
                    {
                        Dye[i].SetDefaults(reader.ReadInt32());
                        Dye[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < Inventory.Length; ++i)
                    {
                        var itemType = reader.ReadInt32();
                        if (itemType >= 3930)
                        {
                            Inventory[i].SetDefaults(0);
                            reader.ReadInt32(); // Stack
                            reader.ReadByte(); // Prefix
                            reader.ReadBoolean(); // Favourite
                        }
                        else
                        {
                            Inventory[i].SetDefaults(itemType);
                            Inventory[i].StackSize = reader.ReadInt32();
                            Inventory[i].Prefix = (ItemPrefix) reader.ReadByte();
                            Inventory[i].IsFavourite = reader.ReadBoolean();
                        }
                    }

                    for (var i = 0; i < MiscEquips.Length; ++i)
                    {
                        var equipType = reader.ReadInt32();
                        if (equipType >= 3930)
                        {
                            MiscEquips[i].SetDefaults(0);
                            reader.ReadByte(); // Prefix
                        }
                        else
                        {
                            MiscEquips[i].SetDefaults(equipType);
                            MiscEquips[i].Prefix = (ItemPrefix) reader.ReadByte();
                        }

                        var dyeType = reader.ReadInt32();
                        if (dyeType >= 3930)
                        {
                            MiscDye[i].SetDefaults(0);
                            reader.ReadByte(); // Prefix
                        }
                        else
                        {
                            MiscDye[i].SetDefaults(dyeType);
                            MiscDye[i].Prefix = (ItemPrefix) reader.ReadByte();
                        }
                    }

                    for (var i = 0; i < PiggyBank.Length; ++i)
                    {
                        PiggyBank[i].SetDefaults(reader.ReadInt32());
                        PiggyBank[i].StackSize = reader.ReadInt32();
                        PiggyBank[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < Safe.Length; ++i)
                    {
                        Safe[i].SetDefaults(reader.ReadInt32());
                        Safe[i].StackSize = reader.ReadInt32();
                        Safe[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < Forge.Length; ++i)
                    {
                        Forge[i].SetDefaults(reader.ReadInt32());
                        Forge[i].StackSize = reader.ReadInt32();
                        Forge[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < Buffs.Length; ++i)
                    {
                        Buffs[i].Id = reader.ReadInt32();
                        Buffs[i].Time = reader.ReadInt32();
                    }

                    for (var i = 0; i < 200; ++i)
                    {
                        var num = reader.ReadInt32();
                        if (num == -1)
                        {
                            break;
                        }

                        // TODO: Figure this out
                        reader.ReadInt32();
                        reader.ReadInt32();
                        reader.ReadString();
                    }

                    IsHotbarLocked = reader.ReadBoolean();
                    for (var i = 0; i < 13; ++i)
                    {
                        reader.ReadBoolean();
                    }

                    AnglerQuestsFinished = reader.ReadInt32();
                    for (var i = 0; i < 4; ++i)
                    {
                        reader.ReadInt32(); // DPad crap (??)
                    }

                    for (var i = 0; i < BuildAccessorieStatus.Length; ++i)
                    {
                        BuildAccessorieStatus[i] = reader.ReadInt32();
                    }

                    reader.ReadInt32(); // Bartender quest log (TODO)
                    PlayerLoaded?.Invoke();
                }
            }
        }
    }
}