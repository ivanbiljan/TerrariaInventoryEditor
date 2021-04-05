using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaKit.Core.Models
{
    /// <summary>
    /// Represents a bit vector that stores a set of 8 flags.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct Flags
    {
        [FieldOffset(0)]
        private byte _vector;

        public bool this[int index]
        {
            get => (_vector & (1 << index)) == 1;
            set
            {
                if (value)
                {
                    _vector |= (byte) (1 << index);
                }
                else
                {
                    _vector &= (byte) ~(1 << index);
                }
            }
        }

        public static implicit operator byte(Flags flags) => flags._vector;
    }
}
