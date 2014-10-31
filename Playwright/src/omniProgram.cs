using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Playwright.src.forms;

namespace Playwright.src
{
    static class omniProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            omniPlaywright.Common.Projects = new Dictionary<int, item>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEditor());
        }
    }
}
