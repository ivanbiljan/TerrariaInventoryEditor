using System;
using System.Drawing;

namespace TerrariaInventoryEditor
{
    internal static class DpiManager
    {
        public enum DeviceCap
        {

        }

        private static int GetScalingFactor()
        {
            using (var gfx = Graphics.FromHwnd(IntPtr.Zero))
            {
                return NativeMethods.GetDeviceCaps(gfx.GetHdc(), 88) * 100 / 96;
            }
        }

        internal static int Scale(int size)
        {
            return size * GetScalingFactor() / 100;
        }
    }
}