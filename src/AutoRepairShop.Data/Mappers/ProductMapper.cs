using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;

namespace AutoRepairShop.Data.Mappers
{
    public class ProductMapper : IStringMapper<Product>
    {
        public Product ToEntity(string[] entity)
        {
            return new Product
            {
                Id = int.Parse(entity[0]),
                Article = entity[1],
                Name = entity[2],
                Description = entity[3],
                Picture = entity[4],
                CategoryId = int.Parse(entity[5]),
                ManufacturerId = int.Parse(entity[6]),
                UnitId = int.Parse(entity[7]),
                Count = int.Parse(entity[8]),
                Discount = float.Parse(entity[9]),
                Price = float.Parse(entity[10])
            };
        }

        public string[] ToString(Product entity)
        {
            return new string[]
            {
                entity.Id.ToString(),
                entity.Article.ToString(),
                entity.Name.ToString(),
                entity.Description.ToString(),
                entity.Picture.ToString(),
                entity.CategoryId.ToString(),
                entity.ManufacturerId.ToString(),
                entity.UnitId.ToString(),
                entity.Count.ToString(),
                entity.Discount.ToString(),
                entity.Price.ToString(),
            };
        }
    }
}
