using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 name:mehul khosla
 date:august 1,2017
 description: the demo app to showcase user interfac
 version: 0.1 - created the project*/
namespace comp123_lesson12A
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Demo());
        }
    }
}
