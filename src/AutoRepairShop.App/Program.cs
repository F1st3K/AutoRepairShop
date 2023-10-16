using AutoRepairShop.App.View.Forms;
using AutoRepairShop.Data;
using System;
using System.Windows.Forms;

namespace AutoRepairShop.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _ = new DataContext("", 
                log => MessageBox.Show(log, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk));
            DataContext.GetInstance().TestConnection();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
