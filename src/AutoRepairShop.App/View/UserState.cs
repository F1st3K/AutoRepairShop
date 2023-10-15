using System;

namespace AutoRepairShop.App.View
{
    static class UserState
    {
        public static Roles Role { get; set; }
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string Patronomic { get; set; }
        public static DateTime DateOfBirth { get; set; }
        public static string Phone { get; set; }

        public static void ClearState()
        {
            Role = Roles.NoAuth;
            Id = 0;
            Name = String.Empty;
            Surname = String.Empty;
            Patronomic = String.Empty;
            DateOfBirth = new DateTime();
            Phone = String.Empty;
        }
    }
}
