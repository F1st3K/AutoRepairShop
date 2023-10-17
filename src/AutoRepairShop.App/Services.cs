using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Services;
using AutoRepairShop.Data.Repositories;

namespace AutoRepairShop.App
{
    static class Services
    {
        public static AuthService<UserRepository, UserInfoRepository> AuthService { get; set; }

        public static SmartSelectService<UserInfo> UserInfoSelectService { get; set; }

        public static SmartSelectService<User> UserSelectService { get; set; }
    }
}
