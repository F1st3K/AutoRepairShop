using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Repositories
{
    interface IRepository<TEntity>
        where TEntity : IEntity
    {
    }
}
