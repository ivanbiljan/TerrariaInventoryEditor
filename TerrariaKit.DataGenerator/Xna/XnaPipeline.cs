using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.DataGenerator.Xna {
    internal static class XnaPipeline
    {
        private const byte CompressedLzxMask = 0x80;
        private const byte CompressedLz4Mask = 0x40;
        
        public static void SaveAsPng(string xnbFilePath)
        {
            if (xnbFilePath is null)
            {
                throw new ArgumentNullException(xnbFilePath);
            }

            if (!File.Exists(xnbFilePath) || !Path.GetExtension(xnbFilePath).Equals(".xnb"))
            {
                throw new ArgumentException("Expected an XNB file", nameof(xnbFilePath));
            }

            using var fileStream = File.OpenRead(xnbFilePath);
            using var binaryReader = new BinaryReader(fileStream);

            binaryReader.BaseStream.Seek(5, SeekOrigin.Begin); // XNB header (3 bytes) + platform (1 byte) + version (1 byte)
            var flags = binaryReader.ReadByte();

            var isCompressedLzx = (flags & CompressedLz4Mask) != 0;
            var isCompressedLz4 = (flags & CompressedLz4Mask) != 0;

            var length = binaryReader.ReadByte();
            if (isCompressedLzx || isCompressedLz4)
            {
                var size = binaryReader.ReadInt32();
                if (isCompressedLzx)
                {
                    var compressedSize = length - 14;
                }
            }
        }
    }
}