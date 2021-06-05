using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TerrariaKit.Services {
    internal sealed class TextureService : ITextureService
    {
        private const string TexturesPath = "Content";
        private const int NumberOfHairTextures = 164;

        // TODO: some sort of resource cleanup should probably be implemented later on
        private readonly IDictionary<string, ImageSource?> _textureCache = new Dictionary<string, ImageSource?>();

        /// <inheritdoc />
        public ImageSource? GetHairTexture(int hairId)
        {
            hairId = hairId <= 0 || hairId >= NumberOfHairTextures ? 1 : hairId;
            if (!_textureCache.TryGetValue($"Player_Hair_{hairId}", out var texture))
            {
                _textureCache[$"Player_Hair_{hairId}"] = texture;
            }

            return null;
        }

        /// <inheritdoc />
        public ImageSource? GetPlayerTexture(int skinVariant, int texture)
        {
            skinVariant = skinVariant < 0 || skinVariant > 11 ? 0 : skinVariant;
            texture = texture < 0 || texture > 15 ? 0 : texture;

            if (_textureCache.TryGetValue($"Player_{skinVariant}_{texture}", out var textureImage))
            {
                return textureImage;
            }

            var path = Path.Combine(TexturesPath, $"Player_{skinVariant}_{texture}");
            if (!File.Exists(path))
            {
                path = Path.Combine(TexturesPath, $"Player_0_{texture}.png");
            }

            return null;
        }

        /// <inheritdoc />
        public ImageSource GetItemTexture(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}