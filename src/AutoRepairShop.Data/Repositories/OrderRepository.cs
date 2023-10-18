using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        public IStringMapper<Order> Mapper => new OrderMapper();

        public int Add(Order entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`orders` " +
                "(`Date`, `Code`, `Status`, `UserInfoId`, `Price`) " +
                "VALUES (@0, @1, @2, @3, @4);" +
                "SELECT LAST_INSERT_ID();";
            var table = DataContext.GetInstance().QueryReturn(query,
                new object[] { entity.Date, entity.Code, entity.Status, entity.UserInfoId, entity.Price });
            return Convert.ToInt32(table[0][0]);
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM `auto_repair_shop`.`orders` WHERE `Id`=@0;";
            DataContext.GetInstance().QueryExecute(query, id);
        }

        public void Edit(Order entity)
        {
            var query = "UPDATE `auto_repair_shop`.`orders` " +
                "SET `Date`=@0, `Code`=@1, `Status`=@2, `UserInfoId`=@3, `Price`=@4, WHERE `Id`=@5;";
            DataContext.GetInstance().QueryExecute(query,
               new object[] { entity.Date, entity.Code, entity.Status, entity.UserInfoId, entity.Price, entity.Id });
        }

        public Order[] GetAll()
        {
            var query = "SELECT * FROM `auto_repair_shop`.`orders`;";
            var table = DataContext.GetInstance().QueryReturn(query);
            var entities = new Order[table.Length];
            for (int i = 0; i < table.Length; i++)
                entities[i] = Mapper.ToEntity(table[i]);
            return entities;
        }

        public bool TryGet(int id, out Order entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`orders` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = Mapper.ToEntity(table[0]);
            return true;
        }
    }
}
