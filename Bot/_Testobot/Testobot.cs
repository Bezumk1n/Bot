using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Bot.Imports.DLLImports;

namespace Bot._Testobot
{
    internal class Testobot
    {
        
        public void Initialize()
        {
            IntPtr result = FindWindow(null, "The.Crowded.Room.S01E07.mkv");
            WINDOWINFO info = new WINDOWINFO();
            GetWindowInfo(result, out info);
        }
        public void Run()
        { 
        }
    }
}
