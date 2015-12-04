using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Auxiliary_Files;
using TaskManager.Source;
using TaskManager.Windows;

namespace TaskManager
{
    static class Program
    {
        public static Interface m_interface { set; get; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            m_interface = new Interface();
			try
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainWindow());
			}
			catch( Exception _e )
			{
				MessageBox.Show(_e.ToString());
			}
        }
    }
}
