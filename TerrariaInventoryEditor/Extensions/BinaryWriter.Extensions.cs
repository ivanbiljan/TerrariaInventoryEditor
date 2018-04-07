using System.Drawing;
using System.IO;

namespace TerrariaInventoryEditor.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="BinaryWriter" /> type.
    /// </summary>
    public static class BinaryWriterExtensions
    {
        /// <summary>
        ///     Writes a <see cref="Color" /> value to the current stream and advances the stream position by three bytes.
        /// </summary>
        /// <param name="writer">The stream.</param>
        /// <param name="color">The color.</param>
        public static void Write(this BinaryWriter writer, Color color)
        {
            byte[] colourBuffer = {color.R, color.G, color.B};
            writer.Write(colourBuffer, 0, 3);
        }
    }
}