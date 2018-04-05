using System.IO;
//using Microsoft.Xna.Framework;
using System.Drawing;

namespace TerrariaInventoryEditor.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="BinaryWriter" /> type.
    /// </summary>
    public static class BinaryWriterExtensions
    {
        /// <summary>
        ///     Writes a color object to the current stream.
        /// </summary>
        /// <param name="writer">The <see cref="BinaryWriter" /> instance.</param>
        /// <param name="color">The color.</param>
        public static void Write(this BinaryWriter writer, Color color)
        {
            byte[] colourBuffer = {color.R, color.G, color.B};
            writer.Write(colourBuffer, 0, 3);
        }
    }
}