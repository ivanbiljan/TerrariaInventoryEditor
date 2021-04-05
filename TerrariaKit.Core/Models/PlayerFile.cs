using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.Core.Models
{
    public sealed class PlayerFile
    {
        private const ulong MagicNumber = 27981915666277746uL;
        private const byte PlayerFileType = 3;
        private uint _revision;

        /// <summary>
        /// Gets the data.
        /// </summary>
        public Character Data { get; init; }
        
        /// <summary>
        /// Gets or sets a value indicating whether this file is favorited.
        /// </summary>
        public bool IsFavorite { get; set; }
        
        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Writes file metadata to the given <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">The writer to write to.</param>
        public void WriteMetadata(BinaryWriter writer)
        {
            writer.Write(0x6369676F6C6572L | ((ulong) PlayerFileType << 56));
            writer.Write(_revision);
            writer.Write((ulong) (IsFavorite ? 1 : 0));
        }

        /// <summary>
        /// Reads a player file from the given <paramref name="reader"/>.
        /// </summary>
        /// <param name="reader">The reader to read from.</param>
        /// <returns>The parsed player file.</returns>
        public void ReadMetadata(BinaryReader reader)
        {
            var hashCode = reader.ReadUInt64();
            if ((hashCode & 0xFFFFFFFFFFFFFFL) != MagicNumber)
            {
                throw new Exception("Expected ReLogic file format");
            }

            var fileType = (byte) ((hashCode >> 56) & 0xFF);
            if (fileType != PlayerFileType)
            {
                throw new Exception("Expected a player file");
            }

            _revision = reader.ReadUInt32();
            IsFavorite = (reader.ReadUInt64() & 1) == 1;
        }
    }
}
