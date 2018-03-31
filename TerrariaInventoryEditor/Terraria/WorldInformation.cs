namespace TerrariaInventoryEditor.Terraria
{
    /// <summary>
    ///     Represents world information.
    /// </summary>
    public sealed class WorldInformation
    {
        /// <summary>
        ///     Gets or sets the world's ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the world's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the world's X spawn coordinate.
        /// </summary>
        public int SpawnX { get; set; }

        /// <summary>
        ///     Gets or sets the world's Y spawn coordinate.
        /// </summary>
        public int SpawnY { get; set; }
    }
}