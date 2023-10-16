using AutoRepairShop.Core.Services;
using AutoRepairShop.Data.Repositories;

namespace AutoRepairShop.App
{
    static class Services
    {
        public static AuthService<UserRepository, UserInfoRepository> AuthService =>
            new AuthService<UserRepository, UserInfoRepository>(
                new UserRepository(), new UserInfoRepository());
    }
}
