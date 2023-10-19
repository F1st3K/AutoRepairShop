
using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class OrderProductRepository : IRepository<OrderProduct>
    {
        public IStringMapper<OrderProduct> Mapper => new OrderProductMapper();

        public int Add(OrderProduct entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`OrderProducts` " +
               "(`OrderId`, `ProductId`, `Count`) " +
               "VALUES (@0, @1, @2);";
            DataContext.GetInstance().QueryExecute(query,
                new object[] { entity.OrderId, entity.ProductId, entity.Count });
            return 0;
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM `auto_repair_shop`.`OrderProducts` WHERE `Id`=@0;";
            DataContext.GetInstance().QueryExecute(query, id);
        }

        public void Edit(OrderProduct entity)
        {
            var query = "UPDATE `auto_repair_shop`.`OrderProducts` " +
                "SET `Count`=@0 WHERE `OrderId`=@1 and `ProductId`=@2;";
            DataContext.GetInstance().QueryExecute(query,
               new object[] { entity.Count, entity.OrderId, entity.ProductId });
        }

        public OrderProduct[] GetAll()
        {
            var query = "SELECT * FROM `auto_repair_shop`.`OrderProducts`;";
            var table = DataContext.GetInstance().QueryReturn(query);
            var entities = new OrderProduct[table.Length];
            for (int i = 0; i < table.Length; i++)
                entities[i] = Mapper.ToEntity(table[i]);
            return entities;
        }

        public bool TryGet(int id, out OrderProduct entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`OrderProducts` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = Mapper.ToEntity(table[0]);
            return true;
        }
    }
}
