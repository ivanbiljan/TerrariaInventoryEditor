using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TerrariaInventoryEditor.TerrariaLib;

namespace TerrariaInventoryEditor.Framework
{
    /// <summary>
    ///     Represents the Texture manager.This class is a singleton.
    /// </summary>
    public sealed class TextureManager
    {
        private static TextureManager _instance;
        private readonly Bitmap[,] _textures = new Bitmap[10, 15];

        /// <summary>
        ///     Gets the <see cref="TextureManager" /> instance.
        /// </summary>
        public static TextureManager Instance => _instance ?? (_instance = new TextureManager());

        /// <summary>
        ///     Gets a <see cref="Bitmap" /> texture mapped to the specified skin variant and texture ID.
        /// </summary>
        /// <param name="skinVariant">The skin variant.</param>
        /// <param name="textureId">The texture ID.</param>
        /// <returns>The corresponding <see cref="Bitmap" />.</returns>
        public Bitmap GetTexture(int skinVariant, PlayerTexture textureId)
        {
            return _textures[skinVariant, (int) textureId]?.Clone() as Bitmap;
        }

        /// <summary>
        ///     Loads all texture files.
        /// </summary>
        public void Load()
        {
            for (var i = 0; i < 10; i++)
            {
                for (var j = 0; j < 15; j++)
                {
                    var textureBitmap = default(Bitmap);
                    try
                    {
                        textureBitmap = new Bitmap($"Data\\PlayerTextures\\Player_{i}_{j}.png");
                    }
                    catch (ArgumentException)
                    {
                        if (j != (int) PlayerTexture.Extras)
                        {
                            textureBitmap = new Bitmap($"Data\\PlayerTextures\\Player_0_{j}.png");
                        }
                    }

                    _textures[i, j] = textureBitmap;
                }
            }
        }
    }
}