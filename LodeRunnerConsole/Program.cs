﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using Controller;
using Microsoft.Win32.SafeHandles;
using View.Game;

namespace LodeRunnerConsole
{
    class Program
    {    
        [STAThread]
        static void Main(string[] args)
        {
            MainController game = new MainController();
            game.InitConsole();
            //KernelGraphics kernelGraphics = new KernelGraphics();
            //kernelGraphics.PrintStrings();
    }
    }
}