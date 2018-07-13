using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TerrariaInventoryEditor.Annotations;
using TerrariaInventoryEditor.Extensions;
using TerrariaInventoryEditor.Framework;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents a Terraria Player.
    /// </summary>
    public sealed class Player : DataSourceObject
    {
        private const string EncryptionKey = "h3y_gUyZ";
        private const ulong MagicNumber = 27981915666277746;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Player" /> class.
        /// </summary>
        public Player()
        {
            Name = "Player name";
            Difficulty = PlayerDifficulty.Softcore;
            SkinVariant = 0;
            Health = 100;
            MaxHealth = 100;
            Mana = 20;
            MaxMana = 20;

            HairColor = Color.FromArgb(215, 90, 55);
            SkinColor = Color.FromArgb(255, 125, 90);
            EyeColor = Color.FromArgb(105, 90, 75);
            ShirtColor = Color.FromArgb(175, 165, 140);
            UndershirtColor = Color.FromArgb(160, 180, 215);
            PantsColor = Color.FromArgb(255, 230, 175);
            ShoeColor = Color.FromArgb(160, 105, 60);

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

            for (var i = 0; i < WorldInfo.Length; ++i)
            {
                WorldInfo[i] = new WorldInformation();
            }
        }

        /// <summary>
        ///     Gets or sets the number of angler quests the player has finished.
        /// </summary>
        public int AnglerQuestsFinished
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's armor.
        ///     Order: 0-2 = Armor, 3-9 = Accessories (1 extra + 1 hidden), 10-12 Social Armor, 13-19 Social Accessories.
        /// </summary>
        public Item[] Armor { get; } = new Item[20];

        /// <summary>
        ///     Pending documentation.
        /// </summary>
        public int BartenderQuestLog
        {
            get => Get<int>();
            set => Set(value);
        }

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
        public PlayerDifficulty Difficulty
        {
            get => Get<PlayerDifficulty>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player has beaten the Old One's Army event.
        /// </summary>
        public bool DownedDd2Event
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's DPad radial bindings.
        /// </summary>
        public int[] DPadRadialBindings { get; } = new int[4];

        /// <summary>
        ///     Gets the player's dye.
        ///     Order: 0-2 = Armor, 3-9 = Accessories (1 extra + 1 hidden).
        /// </summary>
        public Item[] Dye { get; } = new Item[10];

        /// <summary>
        ///     Gets or sets a value indicating whether the player has an extra accessory slot available.
        /// </summary>
        public bool ExtraAccessory
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's eye colour.
        /// </summary>
        public Color EyeColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the path to the player's storage file.
        /// </summary>
        public string FilePath
        {
            get => Get<string>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's forge.
        /// </summary>
        public Item[] Forge { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's hair.
        /// </summary>
        public int Hair
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's hair colour.
        /// </summary>
        public Color HairColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's hair dye.
        /// </summary>
        public byte HairDye
        {
            get => Get<byte>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's current health.
        /// </summary>
        public int Health
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Pending documentation.
        /// </summary>
        public bool[] HideInfo { get; } = new bool[13];

        /// <summary>
        ///     Gets or sets the player's hideMisc property.
        /// </summary>
        public byte HideMisc
        {
            get => Get<byte>();
            set => Set(value);
        }

        /// <summary>
        ///     TODO
        /// </summary>
        public bool[] HideVisuals { get; } = new bool[10];

        /// <summary>
        ///     Gets the player's inventory.
        /// </summary>
        public Item[] Inventory { get; } = new Item[58];

        /// <summary>
        ///     Gets or sets a value indicating whether the player is favourited.
        /// </summary>
        public bool IsFavourite
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player's hotbar has been locked.
        /// </summary>
        public bool IsHotbarLocked
        {
            get => Get<bool>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player is male.
        /// </summary>
        public bool IsMale
        {
            get => SkinVariant < 4 || SkinVariant == 9;
            set
            {
                if (value)
                {
                    SkinVariant = (int) PlayerVariant.MaleStarter;
                }
                else
                {
                    SkinVariant = (int) PlayerVariant.FemaleStarter;
                }
            }
        }

        /// <summary>
        ///     Gets or sets the player's current mana.
        /// </summary>
        public int Mana
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Get or sets the player's max health.
        /// </summary>
        public int MaxHealth
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's max mana.
        /// </summary>
        public int MaxMana
        {
            get => Get<int>();
            set => Set(value);
        }

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
        public string Name
        {
            get => Get<string>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's pants colour.
        /// </summary>
        public Color PantsColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's piggy bank.
        /// </summary>
        public Item[] PiggyBank { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's play time.
        /// </summary>
        public TimeSpan PlayTime
        {
            get => Get<TimeSpan>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the release number.
        /// </summary>
        public int Release
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the revision.
        /// </summary>
        public uint Revision
        {
            get => Get<uint>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's safe.
        /// </summary>
        public Item[] Safe { get; } = new Item[40];

        /// <summary>
        ///     Gets or sets the player's shirt colour.
        /// </summary>
        public Color ShirtColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's shoe colour.
        /// </summary>
        public Color ShoeColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's skin colour.
        /// </summary>
        public Color SkinColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's skin variant. Used to determine the player's gender.
        /// </summary>
        public int SkinVariant
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's tax money.
        /// </summary>
        public int TaxMoney
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the player's undershirt colour.
        /// </summary>
        public Color UndershirtColor
        {
            get => Get<Color>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets the player's world information buffer.
        /// </summary>
        public WorldInformation[] WorldInfo { get; } = new WorldInformation[200];

        /// <summary>
        ///     Loads a player profile from the given path.
        /// </summary>
        /// <param name="playerPath">The path, which must not be <c>null</c>.</param>
        public void Load([NotNull] string playerPath)
        {
            Debug.Assert(playerPath != null, "Player file path must not be null.");

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
                    if (!Terraria.Instance.SupportedVersions.Contains(releaseNumber))
                    {
                        throw new Exception("Unsupported Terraria version.");
                    }
                    if (releaseNumber >= 135)
                    {
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
                    }
                    else
                    {
                        Revision = 0;
                        IsFavourite = false;
                    }

                    Name = reader.ReadString();
                    Difficulty = (PlayerDifficulty) reader.ReadByte();
                    PlayTime = releaseNumber >= 138 ? new TimeSpan(reader.ReadInt64()) : TimeSpan.Zero;
                    Hair = reader.ReadInt32();

                    if (releaseNumber >= 82)
                    {
                        HairDye = reader.ReadByte();
                    }
                    if (releaseNumber >= 124)
                    {
                        var visuals = reader.ReadByte();
                        for (var i = 0; i < 8; ++i)
                        {
                            HideVisuals[i] = visuals.ReadBit(i);
                        }

                        visuals = reader.ReadByte();
                        for (var i = 0; i < 2; ++i)
                        {
                            HideVisuals[i + 8] = visuals.ReadBit(i);
                        }
                    }
                    else if (releaseNumber >= 83)
                    {
                        var visuals = reader.ReadByte();
                        for (var i = 0; i < 8; ++i)
                        {
                            HideVisuals[i] = visuals.ReadBit(i);
                        }
                    }
                    if (releaseNumber >= 119)
                    {
                        HideMisc = reader.ReadByte();
                    }
                    if (releaseNumber < 107)
                    {
                        IsMale = reader.ReadBoolean();
                    }
                    else
                    {
                        SkinVariant = reader.ReadByte();
                    }
                    if (releaseNumber < 161 && SkinVariant == 7)
                    {
                        SkinVariant = 9;
                    }

                    Health = reader.ReadInt32();
                    MaxHealth = reader.ReadInt32();
                    Mana = reader.ReadInt32();
                    MaxMana = reader.ReadInt32();

                    if (releaseNumber >= 125)
                    {
                        ExtraAccessory = reader.ReadBoolean();
                    }
                    if (releaseNumber >= 182)
                    {
                        DownedDd2Event = reader.ReadBoolean();
                    }
                    if (releaseNumber >= 128)
                    {
                        TaxMoney = reader.ReadInt32();
                    }

                    HairColor = reader.ReadColor();
                    SkinColor = reader.ReadColor();
                    EyeColor = reader.ReadColor();
                    ShirtColor = reader.ReadColor();
                    UndershirtColor = reader.ReadColor();
                    PantsColor = reader.ReadColor();
                    ShoeColor = reader.ReadColor();

                    if (releaseNumber < 124)
                    {
                        for (var i = 0; i < (releaseNumber >= 81 ? 16 : 11); ++i)
                        {
                            var index = i >= 8 ? i + 2 : i;
                            Armor[index].SetDefaults(reader.ReadInt32());
                            Armor[index].Prefix = (ItemPrefix) reader.ReadByte();
                        }
                    }
                    else
                    {
                        for (var i = 0; i < Armor.Length; ++i)
                        {
                            Armor[i].SetDefaults(reader.ReadInt32());
                            Armor[i].Prefix = (ItemPrefix) reader.ReadByte();
                        }
                    }
                    if (releaseNumber >= 47)
                    {
                        var dyeCount = releaseNumber >= 124 ? 10 : releaseNumber >= 81 ? 8 : 3;
                        for (var i = 0; i < dyeCount; ++i)
                        {
                            Dye[i].SetDefaults(reader.ReadInt32());
                            Dye[i].Prefix = (ItemPrefix) reader.ReadByte();
                        }
                    }

                    var inventoryCount = releaseNumber >= 58 ? Inventory.Length : 48;
                    for (var i = 0; i < inventoryCount; ++i)
                    {
                        var itemType = reader.ReadInt32();
                        if (itemType >= 3930)
                        {
                            Inventory[i].SetDefaults(0);
                            reader.ReadInt32(); // Stack
                            reader.ReadByte(); // Prefix
                            if (releaseNumber >= 114)
                            {
                                reader.ReadBoolean(); // Favourite
                            }
                        }
                        else
                        {
                            Inventory[i].SetDefaults(itemType);
                            Inventory[i].StackSize = reader.ReadInt32();
                            Inventory[i].Prefix = (ItemPrefix) reader.ReadByte();
                            if (releaseNumber >= 114)
                            {
                                Inventory[i].IsFavourite = reader.ReadBoolean();
                            }
                        }
                    }

                    if (releaseNumber >= 117)
                    {
                        for (var i = 0; i < MiscEquips.Length; ++i)
                        {
                            if (releaseNumber < 136 && i == 1)
                            {
                                continue;
                            }

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
                    }

                    var bankCount = releaseNumber >= 58 ? PiggyBank.Length : 20;
                    for (var i = 0; i < bankCount; ++i)
                    {
                        PiggyBank[i].SetDefaults(reader.ReadInt32());
                        PiggyBank[i].StackSize = reader.ReadInt32();
                        PiggyBank[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    for (var i = 0; i < bankCount; ++i)
                    {
                        Safe[i].SetDefaults(reader.ReadInt32());
                        Safe[i].StackSize = reader.ReadInt32();
                        Safe[i].Prefix = (ItemPrefix) reader.ReadByte();
                    }

                    if (releaseNumber >= 182)
                    {
                        for (var i = 0; i < Forge.Length; ++i)
                        {
                            Forge[i].SetDefaults(reader.ReadInt32());
                            Forge[i].StackSize = reader.ReadInt32();
                            Forge[i].Prefix = (ItemPrefix) reader.ReadByte();
                        }
                    }

                    var buffCount = releaseNumber < 74 ? 10 : 22;
                    for (var i = 0; i < buffCount; ++i)
                    {
                        Buffs[i].SetDefaults(reader.ReadInt32());
                        Buffs[i].Time = reader.ReadInt32();
                    }

                    for (var i = 0; i < WorldInfo.Length; ++i)
                    {
                        var num = reader.ReadInt32();
                        if (num == -1)
                        {
                            break;
                        }

                        WorldInfo[i].SpawnX = num;
                        WorldInfo[i].SpawnY = reader.ReadInt32();
                        WorldInfo[i].Id = reader.ReadInt32();
                        WorldInfo[i].Name = reader.ReadString();
                    }

                    IsHotbarLocked = reader.ReadBoolean();

                    if (releaseNumber >= 115)
                    {
                        for (var i = 0; i < HideInfo.Length; ++i)
                        {
                            HideInfo[i] = reader.ReadBoolean();
                        }
                    }
                    if (releaseNumber >= 98)
                    {
                        AnglerQuestsFinished = reader.ReadInt32();
                    }
                    if (releaseNumber >= 162)
                    {
                        for (var i = 0; i < DPadRadialBindings.Length; ++i)
                        {
                            DPadRadialBindings[i] = reader.ReadInt32();
                        }
                    }
                    if (releaseNumber >= 164)
                    {
                        var buildAccessorieCount = releaseNumber < 167 ? 8 : BuildAccessorieStatus.Length;
                        for (var i = 0; i < buildAccessorieCount; ++i)
                        {
                            BuildAccessorieStatus[i] = reader.ReadInt32();
                        }
                    }
                    if (releaseNumber >= 181)
                    {
                        BartenderQuestLog = reader.ReadInt32();
                    }

                    Release = Terraria.CurrentRelease;
                }
            }
        }

        /// <summary>
        ///     Writes the current player profile to the specified path.
        /// </summary>
        /// <param name="playerPath">The path, which must not be <c>null</c>.</param>
        public void Save([NotNull] string playerPath)
        {
            Debug.Assert(playerPath != null, "Player file path must not be null.");

            if (File.Exists(playerPath))
            {
                File.Copy(playerPath, $"{playerPath}.bak", true);
            }

            using (var rijndaelManaged = new RijndaelManaged())
            using (var fileStream = new FileStream(playerPath, FileMode.Create, FileAccess.ReadWrite))
            {
                var encryption = new UnicodeEncoding().GetBytes(EncryptionKey);
                using (var cryptoStream = new CryptoStream(fileStream,
                    rijndaelManaged.CreateEncryptor(encryption, encryption), CryptoStreamMode.Write))
                using (var writer = new BinaryWriter(cryptoStream))
                {
                    writer.Write(Terraria.CurrentRelease);
                    writer.Write(MagicNumber | (3L << 56));
                    writer.Write(Revision);
                    writer.Write((ulong) ((IsFavourite ? 1 : 0) & 1) | 0);
                    writer.Write(Name);
                    writer.Write((byte) Difficulty);
                    writer.Write(PlayTime.Ticks);
                    writer.Write(Hair);
                    writer.Write(HairDye);

                    byte hideVisuals = 0;
                    for (var i = 0; i < 8; ++i)
                    {
                        hideVisuals.SetBit(i, HideVisuals[i]);
                    }
                    writer.Write(hideVisuals);

                    byte hideVisuals2 = 0;
                    for (var i = 0; i < 2; ++i)
                    {
                        hideVisuals2.SetBit(i, HideVisuals[i + 8]);
                    }
                    writer.Write(hideVisuals2);

                    writer.Write(HideMisc);
                    writer.Write((byte) SkinVariant);
                    writer.Write(Health);
                    writer.Write(MaxHealth);
                    writer.Write(Mana);
                    writer.Write(MaxMana);
                    writer.Write(ExtraAccessory);
                    writer.Write(DownedDd2Event);
                    writer.Write(TaxMoney);
                    writer.Write(HairColor);
                    writer.Write(SkinColor);
                    writer.Write(EyeColor);
                    writer.Write(ShirtColor);
                    writer.Write(UndershirtColor);
                    writer.Write(PantsColor);
                    writer.Write(ShoeColor);

                    for (var i = 0; i < Armor.Length; ++i)
                    {
                        writer.Write(Armor[i].NetId);
                        writer.Write((byte) Armor[i].Prefix);
                    }

                    for (var i = 0; i < Dye.Length; ++i)
                    {
                        writer.Write(Dye[i].NetId);
                        writer.Write((byte) Dye[i].Prefix);
                    }

                    for (var i = 0; i < Inventory.Length; ++i)
                    {
                        writer.Write(Inventory[i].NetId);
                        writer.Write(Inventory[i].StackSize);
                        writer.Write((byte) Inventory[i].Prefix);
                        writer.Write(Inventory[i].IsFavourite);
                    }

                    for (var i = 0; i < MiscEquips.Length; ++i)
                    {
                        writer.Write(MiscEquips[i].NetId);
                        writer.Write((byte) MiscEquips[i].Prefix);
                        writer.Write(MiscDye[i].NetId);
                        writer.Write((byte) MiscDye[i].Prefix);
                    }

                    for (var i = 0; i < PiggyBank.Length; ++i)
                    {
                        writer.Write(PiggyBank[i].NetId);
                        writer.Write(PiggyBank[i].StackSize);
                        writer.Write((byte) PiggyBank[i].Prefix);
                    }

                    for (var i = 0; i < Safe.Length; ++i)
                    {
                        writer.Write(Safe[i].NetId);
                        writer.Write(Safe[i].StackSize);
                        writer.Write((byte) Safe[i].Prefix);
                    }

                    for (var i = 0; i < Forge.Length; ++i)
                    {
                        writer.Write(Forge[i].NetId);
                        writer.Write(Forge[i].StackSize);
                        writer.Write((byte) Forge[i].Prefix);
                    }

                    for (var i = 0; i < Buffs.Length; ++i)
                    {
                        writer.Write(Buffs[i].Id);
                        writer.Write(Buffs[i].Time);
                    }

                    for (var i = 0; i < WorldInfo.Length; ++i)
                    {
                        if (string.IsNullOrWhiteSpace(WorldInfo[i].Name))
                        {
                            writer.Write(-1);
                            break;
                        }

                        writer.Write(WorldInfo[i].SpawnX);
                        writer.Write(WorldInfo[i].SpawnY);
                        writer.Write(WorldInfo[i].Id);
                        writer.Write(WorldInfo[i].Name);
                    }

                    writer.Write(IsHotbarLocked);
                    for (var i = 0; i < HideInfo.Length; ++i)
                    {
                        writer.Write(HideInfo[i]);
                    }

                    writer.Write(AnglerQuestsFinished);
                    for (var i = 0; i < DPadRadialBindings.Length; ++i)
                    {
                        writer.Write(DPadRadialBindings[i]);
                    }

                    for (var i = 0; i < BuildAccessorieStatus.Length; ++i)
                    {
                        writer.Write(BuildAccessorieStatus[i]);
                    }

                    writer.Write(BartenderQuestLog);
                    writer.Flush();
                    cryptoStream.FlushFinalBlock();
                    fileStream.Flush();
                }
            }
        }
    }
}