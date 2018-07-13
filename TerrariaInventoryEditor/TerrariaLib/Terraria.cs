using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents Terraria. This class is a singleton.
    /// </summary>
    public sealed class Terraria
    {
        /// <summary>
        ///     Gets the current release number.
        /// </summary>
        public static readonly int CurrentRelease = 194;

        private static Terraria _instance;

        /// <summary>
        ///     Initializes a new instance of the <see cref="Terraria" /> class.
        /// </summary>
        public Terraria()
        {
            Buffs = JsonConvert.DeserializeObject<List<Buff>>(File.ReadAllText("Data\\Buffs.json"));
            Items = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText("Data\\Items.json"));
        }

        /// <summary>
        ///     Gets the buffs.
        /// </summary>
        public List<Buff> Buffs { get; }

        /// <summary>
        ///     Gets the Terraria instance.
        /// </summary>
        public static Terraria Instance => _instance ?? (_instance = new Terraria());

        /// <summary>
        ///     Gets the items.
        /// </summary>
        public List<Item> Items { get; }

        /// <summary>
        ///     Gets the supported game versions.
        /// </summary>
        public List<int> SupportedVersions { get; } = new List<int>
        {
            38,
            47,
            58,
            74,
            81,
            82,
            83,
            98,
            107,
            114,
            115,
            117,
            119,
            124,
            125,
            128,
            135,
            138,
            161,
            162,
            164,
            167,
            181,
            182,
            194
        };
    }
}