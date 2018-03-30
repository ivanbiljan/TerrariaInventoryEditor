using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TerrariaInventoryEditor.Terraria
{
    /// <summary>
    /// Describes a Terraria Buff.
    /// </summary>
    public sealed class Buff
    {
        /// <summary>
        /// Gets or sets the buff's ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the buff's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the buff's duration time.
        /// </summary>
        [JsonProperty("time")]
        public int Time { get; set; }
    }
}
