namespace TerrariaInventoryEditor.Terraria
{
    /// <summary>
    ///     Specifies an item's rarity.
    /// </summary>
    public enum ItemRarity
    {
        /// <summary>
        ///     The item is a special tier item. Contains quest items.
        /// </summary>
        Amber = -11,

        /// <summary>
        ///     The item is bottom tier. This tier accomodates White/Blue tier items with poor modifiers.
        /// </summary>
        Gray = -1,

        /// <summary>
        ///     The item is default tier. Includes most furniter and early items.
        /// </summary>
        White = 0,

        /// <summary>
        ///     The item is crafted from early ores.
        /// </summary>
        Blue = 1,

        /// <summary>
        ///     The item is a midway pre-hardmode item.
        /// </summary>
        Green = 2,

        /// <summary>
        ///     The item is a late-stage pre-hardmode item.
        /// </summary>
        Orange = 3,

        /// <summary>
        ///     The item is a early-hardmode item.
        /// </summary>
        LightRed = 4,

        /// <summary>
        ///     The item is a mid-hardmode item.
        /// </summary>
        Pink = 5,

        /// <summary>
        ///     The item is a very rare pre-Plantera item.
        /// </summary>
        LightPurple = 6,

        /// <summary>
        ///     The item is acquired around Plantera and Golem.
        /// </summary>
        Lime = 7,

        /// <summary>
        ///     The item is crafted or obtained in the post-Plantera dungeon.
        /// </summary>
        Yellow = 8,

        /// <summary>
        ///     The item is acquired from Lunar Events.
        /// </summary>
        Cyan = 9,

        /// <summary>
        ///     The item is crafted from Lunar Fragments.
        /// </summary>
        Red = 10,

        /// <summary>
        ///     The item contains high-level modifiers.
        /// </summary>
        Purple = 11
    }
}