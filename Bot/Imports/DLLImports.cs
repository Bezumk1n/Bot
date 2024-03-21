using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bot.Imports
{
    internal class DLLImports
    {
        //[StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
        //[StructLayout(LayoutKind.Sequential)]
        public struct WINDOWINFO
        {
            public int cbSize;
            public RECT rcWindow;
            public RECT rcClient;
            public uint dwStyle;
            public uint dwExStyle;
            public uint dwWindowStatus;
            public int cxWindowBorders;
            public int cyWindowBorders;
            public ushort atomWindowType;
            public ushort wCreatorVersion;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string str, string windowName);
        [DllImport("user32.dll")]
        //[return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool GetWindowInfo(IntPtr hWnd, out WINDOWINFO pwi);
    }
}
