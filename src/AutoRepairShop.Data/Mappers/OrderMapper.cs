using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using System;

namespace AutoRepairShop.Data.Mappers
{
    public class OrderMapper : IStringMapper<Order>
    {
        public Order ToEntity(string[] entity)
        {
            return new Order
            {
                Id = int.Parse(entity[0]),
                Date = entity[1],
                Code = entity[2],
                Status = entity[3],
                UserInfoId = int.Parse(entity[4])
            };
        }

        public string[] ToString(Order entity)
        {
            return new string[]
            {
                entity.Id.ToString(),
                entity.Date,
                entity.Code,
                entity.Status.ToString(),
                entity.UserInfoId.ToString(),
            };
        }
    }
}
