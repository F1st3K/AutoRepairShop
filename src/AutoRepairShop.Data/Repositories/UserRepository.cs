using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class UserRepository : IRepository<User>, IUniqNameRepository<User>
    {
        public IStringMapper<User> Mapper => new UserMapper();

        public int Add(User entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`users` " +
                "(`Login`, `Hash`, `RoleId`, `InfoId`) " +
                "VALUES (@0, @1, @2, @3);" +
                "SELECT LAST_INSERT_ID();";
            var table = DataContext.GetInstance().QueryReturn(query,
                new object[] { entity.UniqName, entity.Hash, entity.RoleId, entity.InfoId });
            return Convert.ToInt32(table[0][0]);
        }

        public bool IsUniq(string uname)
        {
            var query = "SELECT * FROM `auto_repair_shop`.`users` WHERE `Login` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, uname);
            return table.Length <= 0;
        }

        public bool TryGet(int id, out User entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`users` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = Mapper.ToEntity(table[0]);
            return true;
        }

        public bool TryGetId(string uname, out int id)
        {
            id = 0;
            var query = "SELECT `Id` FROM `auto_repair_shop`.`users` WHERE `Login` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, uname);
            if (table.Length <= 0 || int.TryParse(table[0][0], out id) == false)
                return false;
            return true;
        }
    }
}
