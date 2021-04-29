using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TerrariaKit.Services {
    internal sealed class TextureService : ITextureService
    {
        private const byte CompressedLzx = 0x80;
        private const byte CompressedLz4 = 0x40;
        private const string TexturesPath = "Content\\Images";
        private const int NumberOfHairTextures = 164;

        // TODO: some sort of resource cleanup should probably be implemented later on
        private readonly IDictionary<string, ImageSource?> _textureCache = new Dictionary<string, ImageSource?>();

        /// <inheritdoc />
        public ImageSource? GetHairTexture(int hairId)
        {
            hairId = hairId <= 0 || hairId >= NumberOfHairTextures ? 1 : hairId;
            if (!_textureCache.TryGetValue($"Player_Hair_{hairId}", out var texture))
            {
                texture = FromXnbImage(Path.Combine(TexturesPath, $"Player_Hair_{hairId}.xnb"));
                _textureCache[$"Player_Hair_{hairId}"] = texture;
            }

            return texture;
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
                path = Path.Combine(TexturesPath, $"Player_0_{texture}");
            }

            return _textureCache[$"Player_{skinVariant}_{texture}"] = FromXnbImage(path);
        }

        /// <inheritdoc />
        public ImageSource GetItemTexture(int itemId)
        {
            throw new NotImplementedException();
        }

        private static BitmapSource? FromXnbImage(string filePath)
        {
            if (filePath is null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            if (!File.Exists(filePath) || Path.GetExtension(filePath) != ".xnb")
            {
                throw new ArgumentException($"Invalid .xnb resource path: {filePath}", nameof(filePath));
            }

            using var fileStream = File.OpenRead(filePath);
            using var binaryReader = new BinaryReader(fileStream);

            // XNB header (3 bytes) + platform (1 byte) + version (1 byte) + flags(1 byte)
            binaryReader.BaseStream.Seek(5, SeekOrigin.Begin);
            var flags = binaryReader.ReadByte();
            if ((flags & CompressedLzx) != 0 || (flags & CompressedLz4) != 0)
            {
                var size = binaryReader.ReadInt32();
            }

            // Read the actual image
            var surfaceFormat = binaryReader.ReadInt32(); // surface format
            var width = binaryReader.ReadInt32();
            var height = binaryReader.ReadInt32();
            binaryReader.ReadInt32(); // level count
            binaryReader.ReadInt32(); // compression type

            var buffer = binaryReader.ReadBytes(width * height * 4);
            return GetImageFromBytes(buffer);
        }

        private static BitmapSource GetImageFromBytes(byte[] bytes)
        {
            using var memoryStream = new MemoryStream(bytes);
            //memoryStream.Position = 0;
            memoryStream.Position = 0;
            return BitmapDecoder.Create(memoryStream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad).Frames[0];

            //var result = new BitmapImage();
            //result.BeginInit();
            //result.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
            //result.CacheOption = BitmapCacheOption.OnLoad;
            //result.UriSource = null;
            //result.StreamSource = memoryStream;
            //result.EndInit();
            //result.Freeze();

            //return result;
        }
    }
}