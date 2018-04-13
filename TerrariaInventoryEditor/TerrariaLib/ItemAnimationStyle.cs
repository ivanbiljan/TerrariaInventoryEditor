namespace TerrariaInventoryEditor.TerrariaLib
{
    /// <summary>
    ///     Specifies an item's animation style.
    /// </summary>
    public enum ItemAnimationStyle
    {
        /// <summary>
        ///     The item has no animation style.
        /// </summary>
        None = 0,

        /// <summary>
        ///     The item is a swingable item.
        /// </summary>
        Swing = 1,

        /// <summary>
        ///     The item is a consumable.
        /// </summary>
        Consume = 2,

        /// <summary>
        ///     The item uses the stab animation.
        /// </summary>
        Stab = 3,

        /// <summary>
        ///     The item can be held.
        /// </summary>
        Hold = 4,

        /// <summary>
        ///     The item is shootable.
        /// </summary>
        Shoot = 5
    }
}