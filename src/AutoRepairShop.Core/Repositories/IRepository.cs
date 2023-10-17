using AutoRepairShop.Core.Entities.Interfaces;
using AutoRepairShop.Core.Mappers;

namespace AutoRepairShop.Core.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        IStringMapper<TEntity> Mapper { get; }
        bool TryGet(int id, out TEntity entity);
        int Add(TEntity entity);
        TEntity[] GetAll();
        void Delete(int id);
        void Edit(TEntity entity);
    }
}
