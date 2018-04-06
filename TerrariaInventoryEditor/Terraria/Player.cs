using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using TerrariaInventoryEditor.Annotations;
using TerrariaInventoryEditor.Extensions;

namespace TerrariaInventoryEditor.Terraria
{
    public delegate void PlayerLoadedD();

    public delegate void PlayerSavedD();

    /// <summary>
    ///     Represents a Terraria Player.
    /// </summary>
    // TODO: Implement older version support []
    // TODO: Hide misc implementation - [X]
    // TODO: Downed DD2 implementation - [X]
    // TODO: Spawn points implementation - [X]
    // TODO: Hide info implementation - [X]
    public sealed class Player : INotifyPropertyChanged
    {
        private const string EncryptionKey = "h3y_gUyZ";

        private const ulong MagicNumber = 27981915666277746;

        private int _anglerQuestsFinished;

        private int _bartenderQuestLog;

        private int _currentHealth;

        private int _currentMana;

        private PlayerDifficulty _difficulty;

        private bool _downedDD2Event;

        private bool _extraAccessory;

        private Color _eyeColor;

        private string _filePath;

        private int _hair;

        private Color _hairColor;

        private byte _hairDye;

        private byte _hideMisc;

        private bool _isFavourite;

        private bool _isHotbarLocked;

        private int _maxHealth;

        private int _maxMana;

        private string _name;

        private Color _pantsColor;

        private TimeSpan _playTime;

        private int _release;

        private uint _revision;

        private Color _shirtColor;

        private Color _shoeColor;

        private Color _skinColor;

        private int _skinVariant;

        private int _taxMoney;

        private Color _undershirtColor;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Player" /> class.
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
            get => _anglerQuestsFinished;
            set
            {
                if (value == _anglerQuestsFinished)
                {
                    return;
                }

                _anglerQuestsFinished = value;
                OnPropertyChanged();
            }
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
            get => _bartenderQuestLog;
            set
            {
                if (value == _bartenderQuestLog)
                {
                    return;
                }

                _bartenderQuestLog = value;
                OnPropertyChanged();
            }
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
            get => _difficulty;
            set
            {
                if (value == _difficulty)
                {
                    return;
                }

                _difficulty = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player has beaten the Old One's Army event.
        /// </summary>
        public bool DownedDd2Event
        {
            get => _downedDD2Event;
            set
            {
                if (value == _downedDD2Event)
                {
                    return;
                }

                _downedDD2Event = value;
                OnPropertyChanged();
            }
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
            get => _extraAccessory;
            set
            {
                if (value == _extraAccessory)
                {
                    return;
                }

                _extraAccessory = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's eye colour.
        /// </summary>
        public Color EyeColor
        {
            get => _eyeColor;
            set
            {
                if (value == _eyeColor)
                {
                    return;
                }

                _eyeColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets the path to the player's storage file.
        /// </summary>
        public string FilePath
        {
            get => _filePath;
            set
            {
                if (value == _filePath)
                {
                    return;
                }

                _filePath = value;
                OnPropertyChanged();
            }
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
            get => _hair;
            set
            {
                if (value == _hair)
                {
                    return;
                }

                _hair = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's hair colour.
        /// </summary>
        public Color HairColor
        {
            get => _hairColor;
            set
            {
                if (value == _hairColor)
                {
                    return;
                }

                _hairColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's hair dye.
        /// </summary>
        public byte HairDye
        {
            get => _hairDye;
            set
            {
                if (value == _hairDye)
                {
                    return;
                }

                _hairDye = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's current health.
        /// </summary>
        public int Health
        {
            get => _currentHealth;
            set
            {
                if (value == _currentHealth)
                {
                    return;
                }

                _currentHealth = value;
                OnPropertyChanged();
            }
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
            get => _hideMisc;
            set
            {
                if (value == _hideMisc)
                {
                    return;
                }

                _hideMisc = value;
                OnPropertyChanged();
            }
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
            get => _isFavourite;
            set
            {
                if (value == _isFavourite)
                {
                    return;
                }

                _isFavourite = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player's hotbar has been locked.
        /// </summary>
        public bool IsHotbarLocked
        {
            get => _isHotbarLocked;
            set
            {
                if (value == _isHotbarLocked)
                {
                    return;
                }

                _isHotbarLocked = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets a value indicating whether the player is male.
        /// </summary>
        [Obsolete("Use Player.SkinVariant instead.")]
        public bool IsMale { get; set; }

        /// <summary>
        ///     Gets or sets the player's current mana.
        /// </summary>
        public int Mana
        {
            get => _currentMana;
            set
            {
                if (value == _currentMana)
                {
                    return;
                }

                _currentMana = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Get or sets the player's max health.
        /// </summary>
        public int MaxHealth
        {
            get => _maxHealth;
            set
            {
                if (value == _maxHealth)
                {
                    return;
                }

                _maxHealth = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's max mana.
        /// </summary>
        public int MaxMana
        {
            get => _maxMana;
            set
            {
                if (value == _maxMana)
                {
                    return;
                }

                _maxMana = value;
                OnPropertyChanged();
            }
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
            get => _name;
            set
            {
                if (value == _name)
                {
                    return;
                }

                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's pants colour.
        /// </summary>
        public Color PantsColor
        {
            get => _pantsColor;
            set
            {
                if (value == _pantsColor)
                {
                    return;
                }

                _pantsColor = value;
                OnPropertyChanged();
            }
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
            get => _playTime;
            set
            {
                if (value == _playTime)
                {
                    return;
                }

                _playTime = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the release number.
        /// </summary>
        public int Release
        {
            get => _release;
            set
            {
                if (value == _release)
                {
                    return;
                }

                _release = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the revision.
        /// </summary>
        public uint Revision
        {
            get => _revision;
            set
            {
                if (value == _revision)
                {
                    return;
                }

                _revision = value;
                OnPropertyChanged();
            }
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
            get => _shirtColor;
            set
            {
                if (value == _shirtColor)
                {
                    return;
                }

                _shirtColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's shoe colour.
        /// </summary>
        public Color ShoeColor
        {
            get => _shoeColor;
            set
            {
                if (value == _shoeColor)
                {
                    return;
                }

                _shoeColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's skin colour.
        /// </summary>
        public Color SkinColor
        {
            get => _skinColor;
            set
            {
                if (value == _skinColor)
                {
                    return;
                }

                _skinColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's skin variant. Used to determine the player's gender.
        /// </summary>
        public int SkinVariant
        {
            get => _skinVariant;
            set
            {
                if (value == _skinVariant)
                {
                    return;
                }

                _skinVariant = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's tax money.
        /// </summary>
        public int TaxMoney
        {
            get => _taxMoney;
            set
            {
                if (value == _taxMoney)
                {
                    return;
                }

                _taxMoney = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the player's undershirt colour.
        /// </summary>
        public Color UndershirtColor
        {
            get => _undershirtColor;
            set
            {
                if (value == _undershirtColor)
                {
                    return;
                }

                _undershirtColor = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets the player's world information buffer.
        /// </summary>
        public WorldInformation[] WorldInfo { get; } = new WorldInformation[200];

        /// <summary>
        ///     Occurs when a property is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
        /// <param name="playerPath">The path, which must not be null.</param>
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

                    visuals = reader.ReadByte();
                    for (var i = 0; i < 2; ++i)
                    {
                        HideVisuals[i + 8] = visuals.ReadBit(i);
                    }

                    HideMisc = reader.ReadByte();
                    SkinVariant = reader.ReadByte();
                    Health = reader.ReadInt32();
                    MaxHealth = reader.ReadInt32();
                    Mana = reader.ReadInt32();
                    MaxMana = reader.ReadInt32();
                    ExtraAccessory = reader.ReadBoolean();
                    DownedDd2Event = reader.ReadBoolean();
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
                    for (var i = 0; i < HideInfo.Length; ++i)
                    {
                        HideInfo[i] = reader.ReadBoolean();
                    }

                    AnglerQuestsFinished = reader.ReadInt32();
                    for (var i = 0; i < DPadRadialBindings.Length; ++i)
                    {
                        DPadRadialBindings[i] = reader.ReadInt32();
                    }

                    for (var i = 0; i < BuildAccessorieStatus.Length; ++i)
                    {
                        BuildAccessorieStatus[i] = reader.ReadInt32();
                    }

                    BartenderQuestLog = reader.ReadInt32();
                    PlayerLoaded?.Invoke();
                }
            }
        }

        /// <summary>
        ///     Writes the current player profile to the specified path.
        /// </summary>
        /// <param name="playerPath">The path, which must not be null.</param>
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
                    PlayerSaved?.Invoke();
                }
            }
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}