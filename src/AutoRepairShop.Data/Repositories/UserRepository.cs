using AutoRepairShop.Core.Entity;
using AutoRepairShop.Core.Repositories;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class UserRepository : IRepository<User>, IUniqNameRepository<User>
    {
        public int Add(User entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`users` " +
                "(`Login`, `Hash`, `RoleId`, `InfoId`) " +
                "VALUES (@0, @1, @2, @3);" +
                "SELECT LAST_INSERT_ID();";
            var table = DataContext.GetInstance().QueryReturn(query,
                new object[] { entity.UniqName, entity.Hash, entity.RoleId, entity.InfoId });
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public bool IsUniq(string uname)
        {
            var query = "SELECT * FROM `auto_repair_shop`.`users` WHERE `Login` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, uname);
            return table.Rows.Count <= 0;
        }

        public bool TryGet(int id, out User entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`users` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Rows.Count <= 0)
                return false;
            entity = new User
            {
                Id = (int)table.Rows[0][0],
                UniqName = (string)table.Rows[0][1],
                Hash = (string)table.Rows[0][2],
                RoleId = (int)table.Rows[0][3],
                InfoId = (int)table.Rows[0][4]
            };
            return true;
        }

        public bool TryGetId(string uname, out int id)
        {
            id = 0;
            var query = "SELECT `Id` FROM `auto_repair_shop`.`users` WHERE `Login` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, uname);
            if (table.Rows.Count <= 0)
                return false;
            id = (int)table.Rows[0][0];
            return true;
        }
    }
}
