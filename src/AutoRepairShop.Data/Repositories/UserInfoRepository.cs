using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Entities.Interfaces;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class UserInfoRepository : IRepository<UserInfo>
    {
        public IStringMapper<UserInfo> Mapper => new UserInfoMapper();

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

        public UserInfo[] GetAll()
        {
            var query = "SELECT * FROM `auto_repair_shop`.`usersinfo`;";
            var table = DataContext.GetInstance().QueryReturn(query);
            var entities = new UserInfo[table.Length];
            for (int i = 0; i < table.Length; i++)
                entities[i] = Mapper.ToEntity(table[i]);
            return entities;
        }

        public bool TryGet(int id, out UserInfo entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`usersinfo` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = Mapper.ToEntity(table[0]);
            return true;
        }
    }
}
