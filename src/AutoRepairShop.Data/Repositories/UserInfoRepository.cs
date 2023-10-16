using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Repositories;
using MySql.Data.MySqlClient;

namespace AutoRepairShop.Data.Repositories
{
    public class UserInfoRepository : IRepository<UserInfo>
    {
        public int Add(UserInfo entity)
        {
            var query = "INSERT INTO `auto_repair_shop`.`usersinfo` " +
                "(`Name`, `Surname`, `Patronymic`, `DataOfBirth`, `Phone`) " +
                "VALUES (@Name, @Surname, @Patronomic, @DOB, @Phone);" +
                "SELECT LAST_INSERT_ID();";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Name", entity.Name),
                new MySqlParameter("@Surname", entity.Surname),
                new MySqlParameter("@Patronomic", entity.Patronomic),
                new MySqlParameter("@DOB", entity.DOB),
                new MySqlParameter("@Phone", entity.Phone),
            };
            var table = DataContext.GetInstance().QueryReturn(query, parameters);
            return (int)table.Rows[0][0];
        }

        public bool TryGet(int id, out UserInfo entity)
        {
            throw new System.Exception();
        }
    }
}
