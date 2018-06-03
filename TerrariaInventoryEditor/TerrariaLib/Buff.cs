using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json;
using TerrariaInventoryEditor.Framework;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents a Terraria buff.
    /// </summary>
    public sealed class Buff : DataSourceObject
    {
        /// <summary>
        ///     Gets or sets the buff's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get => Get<string>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the buff's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the buff's image.
        /// </summary>
        public Bitmap Image => new Bitmap($"Data\\BuffTextures\\Buff_{Id}.png");

        /// <summary>
        ///     Gets or sets the buff's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get => Get<string>();
            set => Set(value);
        }

        /// <summary>
        ///     Gets or sets the buff's duration.
        /// </summary>
        [JsonProperty("time")]
        public int Time
        {
            get => Get<int>();
            set => Set(value);
        }

        /// <summary>
        ///     Returns the string representation of this buff.
        /// </summary>
        /// <returns>The string representation of this buff.</returns>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        ///     Constructs the buff based on the specified buff ID.
        /// </summary>
        /// <param name="buffId">The buff ID.</param>
        public void SetDefaults(int buffId)
        {
            Debug.Assert(buffId >= 0, "Buff ID must not be negative.");
            Debug.Assert(buffId < Terraria.Instance.Buffs.Count,
                "Buff ID must not be greater than the size of buff collection.");

            var buff = Terraria.Instance.Buffs.SingleOrDefault(b => b.Id == buffId);
            if (buff == null)
            {
                return;
            }

            Description = buff.Description;
            Id = buff.Id;
            Name = buff.Name;
        }
    }
}