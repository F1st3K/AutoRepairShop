using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Repositories
{
    interface IRepository<TEntity>
        where TEntity : IEntity
    {
        bool TryGet(int id, out TEntity entity);
        int Add(TEntity entity);
    }
}
