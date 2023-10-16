using AutoRepairShop.Core.Entity;
using AutoRepairShop.Core.Repositories;

namespace AutoRepairShop.Data.Repositories
{
    public class UserRepository : IRepository<User>, IUniqNameRepository<User>
    {
        public int Add(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool IsUniq(string uname)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGet(int id, out User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool TryGetId(string uname, out int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
