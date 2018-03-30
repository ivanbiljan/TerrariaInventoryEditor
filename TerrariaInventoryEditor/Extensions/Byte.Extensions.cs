namespace TerrariaInventoryEditor.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="byte" /> type.
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        ///     Returns the boolean state of the bit at the specified position of a byte.
        /// </summary>
        /// <param name="byte">The byte.</param>
        /// <param name="position">The bit's position.</param>
        /// <returns><c>true</c> if the read bit is set to 1; otherwise, <c>false</c>.</returns>
        public static bool ReadBit(this byte @byte, int position)
        {
            return (@byte & (1 << position)) != 0;
        }
    }
}