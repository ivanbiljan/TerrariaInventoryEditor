namespace TerrariaInventoryEditor.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="byte" /> type.
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        ///     Returns the boolean state of a bit at the specified position of the byte.
        /// </summary>
        /// <param name="byte">The byte.</param>
        /// <param name="position">The bit's position.</param>
        /// <returns><c>true</c> if the read bit is set to 1; otherwise, <c>false</c>.</returns>
        public static bool ReadBit(this byte @byte, int position)
        {
            return (@byte & (1 << position)) != 0;
        }

        /// <summary>
        ///     Sets a bit of the current byte to the specified value.
        /// </summary>
        /// <param name="byte">The byte.</param>
        /// <param name="bit">The bit's position.</param>
        /// <param name="value">The value.</param>
        /// <returns>The modified byte.</returns>
        public static byte SetBit(this byte @byte, int bit, bool value)
        {
            if (value)
            {
                return @byte = (byte) (@byte | (1 << bit));
            }
            return @byte = (byte) (@byte & ~(1 << bit));
        }
    }
}