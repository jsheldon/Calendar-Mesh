using System;
using System.Windows.Forms;
using StructureMap;

namespace CalendarMesh
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainform = ObjectFactory.GetInstance<MainForm>();
            Application.Run(mainform);
        }
    }
}