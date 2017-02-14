using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fileviewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string fileToOpen = String.Empty;
            if (args.Length > 0)
            {
                fileToOpen = args[0];
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XMLConfiguration settings = new XMLConfiguration("H:\\windows\\cpm\\Program\\SFS Fileviewer", "userSettings.xml");
            Application.Run(new EditorView(new EditorModel(settings), fileToOpen, settings));
        }
    }
}
