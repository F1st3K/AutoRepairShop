using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;
using System;

namespace AutoRepairShop.Data.Mappers
{
    public class UserInfoMapper : IStringMapper<UserInfo>
    {
        public UserInfo ToEntity(string[] entity)
        {
            if (DateTime.TryParse(entity[4], out var dob))
                entity[4] = dob.ToString("yyyy-MM-dd");
            return new UserInfo
            {
                Id = int.Parse(entity[0]),
                Name = entity[1],
                Surname = entity[2],
                Patronomic = entity[3],
                DOB = entity[4],
                Phone = entity[5]
            };
        }

        public string[] ToString(UserInfo entity)
        {
            return new string[]
            {
                entity.Id.ToString(),
                entity.Name,
                entity.Surname,
                entity.Patronomic,
                entity.DOB,
                entity.Phone
            };
        }
    }
}
