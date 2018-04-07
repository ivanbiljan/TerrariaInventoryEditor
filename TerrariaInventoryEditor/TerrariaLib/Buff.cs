using Newtonsoft.Json;

namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Represents a Terraria buff.
    /// </summary>
    public sealed class Buff
    {
        /// <summary>
        ///     Gets or sets the buff's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the buff's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the buff's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the buff's duration time.
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}