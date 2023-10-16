using AutoRepairShop.App.View.Forms;
using AutoRepairShop.Core.Services;
using AutoRepairShop.Data;
using AutoRepairShop.Data.Repositories;
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
            //dependensy for data base (mySql)
            _ = new DataContext(
                "host='localhost';" +
                "database='auto_repair_shop';" +
                "uid='root';" +
                "pwd='root';" +
                "charset=utf8;",
            log => MessageBox.Show(log,
                "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk));

            DataContext.GetInstance().TestConnection();
            //dependensy for AuthService
            Services.AuthService = new AuthService<UserRepository, UserInfoRepository>(
                new UserRepository(), new UserInfoRepository());

            //Run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
