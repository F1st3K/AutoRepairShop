using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Repositories;
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
                entity.Name, entity.Surname, entity.Patronomic, entity.DOB, entity.Phone);
            return (int)table.Rows[0][0];
        }

        public bool TryGet(int id, out UserInfo entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`usersinfo` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Rows.Count <= 0)
                return false;
            entity = new UserInfo
            {
                Id = (int)table.Rows[0][0],
                Name = (string)table.Rows[0][1],
                Surname = (string)table.Rows[0][2],
                Patronomic = (string)table.Rows[0][3],
                DOB = ((DateTime)table.Rows[0][4]).ToString("yyyy-MM-dd"),
                Phone = (string)table.Rows[0][5]
            };
            return true;
        }
    }
}
