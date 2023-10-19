using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Mappers;

namespace AutoRepairShop.Data.Mappers
{
    public class UserMapper : IStringMapper<User>
    {
        public User ToEntity(string[] entity)
        {
            return new User
            {
                Id = int.Parse(entity[0]),
                UniqName = entity[1],
                Hash = entity[2],
                RoleId = int.Parse(entity[3]),
                InfoId = int.Parse(entity[4])
            };
        }

        public string[] ToString(User entity)
        {
            return new string[] 
            { 
                entity.Id.ToString(),
                entity.UniqName,
                entity.Hash,
                entity.RoleId.ToString(),
                entity.InfoId.ToString()
            };
        }
    }
}
