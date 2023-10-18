using AutoRepairShop.App.View.Forms;
using AutoRepairShop.Core.Services;
using AutoRepairShop.Data;
using AutoRepairShop.Data.Mappers;
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
            Services.HashService = new HashService();
            Services.AuthService = new AuthService<UserRepository, UserInfoRepository>(
                new UserRepository(), new UserInfoRepository(), Services.HashService);
            Services.UserService = new UserService<UserRepository, UserInfoRepository>(
                new UserRepository(), new UserInfoRepository());
            Services.OrderService = new OrderService<OrderRepository, OrderProductRepository>(
                new OrderRepository(), new OrderProductRepository());

            //dependensy for SmartSelectService
            Services.UserInfoSelectService = new SmartSelectService<Core.Entities.UserInfo>(
                new UserInfoRepository(), new UserInfoMapper());
            Services.UserSelectService = new SmartSelectService<Core.Entities.User>(
                new UserRepository(), new UserMapper());
            Services.ProductSelectService = new SmartSelectService<Core.Entities.Product>(
                new ProductRepository(), new ProductMapper());
            Services.OrderSelectService = new SmartSelectService<Core.Entities.Order>(
                new OrderRepository(), new OrderMapper());

            //Run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
