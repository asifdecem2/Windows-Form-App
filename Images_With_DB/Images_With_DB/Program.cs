﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images_With_DB
{
    static class Program
    {
        //public static Form1 f1;
       // public static Form2 f2;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // f1 = new Form1();
            //Application.Run(Program.f1);
            //f2 = new Form2();
            Application.Run(new Form1());
           // Application.Run(Program.f2);
        }
    }
}
