using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents Terraria.
    /// </summary>
    public sealed class Terraria
    {
        /// <summary>
        ///     Gets the current release number.
        /// </summary>
        public const int CurrentRelease = 194;

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
        ///     Gets the list of buffs.
        /// </summary>
        public List<Buff> Buffs { get; }

        /// <summary>
        ///     Gets the Terraria instance.
        /// </summary>
        public static Terraria Instance => _instance ?? (_instance = new Terraria());

        /// <summary>
        ///     Gets the list of items.
        /// </summary>
        public List<Item> Items { get; }

        /// <summary>
        ///     Gets the player instance that's being edited.
        /// </summary>
        public Player Player { get; set; } = new Player();
    }
}