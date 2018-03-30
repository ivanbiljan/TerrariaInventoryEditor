using System.Drawing;
using System.IO;

namespace TerrariaInventoryEditor.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="BinaryReader" /> type.
    /// </summary>
    public static class BinaryReaderExtensions
    {
        /// <summary>
        ///     Reads a color from the specified reader.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The color.</returns>
        public static Color ReadColor(this BinaryReader reader)
        {
            var payload = reader.ReadBytes(3);
            return Color.FromArgb(payload[0], payload[1], payload[2]);
        }
    }
}