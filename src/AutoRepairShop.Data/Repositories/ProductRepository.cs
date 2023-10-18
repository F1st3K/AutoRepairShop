using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using AutoRepairShop.Data.Mappers;
using System;

namespace AutoRepairShop.Data.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public IStringMapper<Product> Mapper => new ProductMapper();

        public int Add(Product entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`products` " +
                "(`Article`, `Name`, `Description`, `Picture`, `CategoryId`, " +
                "`ManufacturerId`, `UnitId`, `QuantityInStock`, `Discount`, `Price`) " +
                "VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9);" +
                "SELECT LAST_INSERT_ID();";
            var table = DataContext.GetInstance().QueryReturn(query,
                new object[] { 
                    entity.Article, entity.Name, entity.Description, entity.Picture,
                    entity.CategoryId, entity.ManufacturerId, entity.UnitId,
                    entity.Count, entity.Discount, entity.Price });
            return Convert.ToInt32(table[0][0]);
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM `auto_repair_shop`.`products` WHERE `Id`=@0;";
            DataContext.GetInstance().QueryExecute(query, id);
        }

        public void Edit(Product entity)
        {
            var query = "UPDATE `auto_repair_shop`.`products` " +
                "SET `Article`=@0, `Name`=@1, `Description`=@2, `Picture`=@3, `CategoryId`=@4, `ManufacturerId`=@5, `UnitId`=@6, `QuantityInStock`=@7, `Discount`=@8, `Price`=@9, `Id`=@10;";
            DataContext.GetInstance().QueryExecute(query,
                new object[] {
                    entity.Article, entity.Name, entity.Description, entity.Picture,
                    entity.CategoryId, entity.ManufacturerId, entity.UnitId,
                    entity.Count, entity.Discount, entity.Price, entity.Id });
        }

        public Product[] GetAll()
        {
            var query = "SELECT * FROM `auto_repair_shop`.`products`;";
            var table = DataContext.GetInstance().QueryReturn(query);
            var entities = new Product[table.Length];
            for (int i = 0; i < table.Length; i++)
                entities[i] = Mapper.ToEntity(table[i]);
            return entities;
        }

        public bool TryGet(int id, out Product entity)
        {
            entity = null;
            var query = "SELECT * FROM `auto_repair_shop`.`products` WHERE `Id` LIKE @0;";
            var table = DataContext.GetInstance().QueryReturn(query, id);
            if (table.Length <= 0)
                return false;
            entity = Mapper.ToEntity(table[0]);
            return true;
        }
    }
}
