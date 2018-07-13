using System;
using System.Runtime.InteropServices;

namespace TerrariaInventoryEditor
{
    internal static class NativeMethods
    {
        [DllImport("gdi32.dll")]
        public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
    }
}