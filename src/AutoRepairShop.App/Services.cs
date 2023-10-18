using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Services;
using AutoRepairShop.Data.Repositories;

namespace AutoRepairShop.App
{
    static class Services
    {
        public static HashService HashService { get; set; }

        public static AuthService<UserRepository, UserInfoRepository> AuthService { get; set; }

        public static SmartSelectService<UserInfo> UserInfoSelectService { get; set; }

        public static SmartSelectService<User> UserSelectService { get; set; }

        public static UserService<UserRepository, UserInfoRepository> UserService { get; set; }

        public static SmartSelectService<Product> ProductSelectService { get; set; }

        public static SmartSelectService<Order> OrderSelectService { get; set; }

        public static OrderService<OrderRepository, OrderProductRepository> OrderService { get; set; }
    }
}
