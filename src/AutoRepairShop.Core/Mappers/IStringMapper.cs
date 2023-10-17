using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Mappers
{
    public interface IStringMapper<TEntity>
        where TEntity : IEntity
    {
        string[] ToString(TEntity entity);
        TEntity ToEntity(string[] entity);
    }
}
