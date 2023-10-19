using AutoRepairShop.Core.Entities;
using System;

namespace AutoRepairShop.App.View
{
    static class State
    {
        public static UserInfo UserInfo { get; set; }
        public static UserInfo OrderUserInfo { get; set; }
        public static Roles UserRole { get; set; }

        public static void ClearUserState()
        {
            UserRole = Roles.NoAuth;
            UserInfo = new UserInfo
            {
                Id = 0,
                Name = String.Empty,
                Surname = String.Empty,
                Patronomic = String.Empty,
                DOB = String.Empty,
                Phone = String.Empty,
            };
            OrderUserInfo = null;
        }
    }
}
