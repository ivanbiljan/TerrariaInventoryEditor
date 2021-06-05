using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.Core.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static Color ReadRgb(this BinaryReader reader)
        {
            return Color.FromArgb(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
        }
    }
}