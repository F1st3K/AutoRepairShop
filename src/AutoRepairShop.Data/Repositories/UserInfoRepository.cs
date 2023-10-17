using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class UserInfoRepository : IRepository<UserInfo>
    {
        public int Add(UserInfo entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`usersinfo` " +
                "(`Name`, `Surname`, `Patronymic`, `DataOfBirth`, `Phone`) " +
                "VALUES (@0, @1, @2, @3, @4);" +
                "SELECT LAST_INSERT_ID();";
            var table = DataContext.GetInstance().QueryReturn(query,
                new object[] { entity.Name, entity.Surname, entity.Patronomic, entity.DOB, entity.Phone });
            return Convert.ToInt32(table[0][0]);
        }

        public bool TryGet(int id, out UserInfo entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`usersinfo` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = UserInfoMapper.Mappers.ToEntity(table[0]);
            return true;
        }
    }
}
