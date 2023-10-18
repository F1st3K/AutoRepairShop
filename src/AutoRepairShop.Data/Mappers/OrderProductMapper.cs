using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;

namespace AutoRepairShop.Data.Mappers
{
    public class OrderProductMapper : IStringMapper<OrderProduct>
    {
        public OrderProduct ToEntity(string[] entity)
        {
            return new OrderProduct
            {
                OrderId = int.Parse(entity[1]),
                ProductId= int.Parse(entity[2]),
                Count = int.Parse(entity[3]),
            };
        }

        public string[] ToString(OrderProduct entity)
        {
            return new string[]
            {
                entity.Id.ToString(),
                entity.OrderId.ToString(),
                entity.ProductId.ToString(),
                entity.Count.ToString(),
            };
        }
    }
}
