using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColorPicker;
using ColorPicker.Features.Shell;
using ColorPicker.Services;
using Splat;

namespace ColorPicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Locator.CurrentMutable.RegisterConstant(new LoggingService(), typeof(ILogger));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShellForm());
        }
    }
}
