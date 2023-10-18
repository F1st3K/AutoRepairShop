using AutoRepairShop.Core.Entities;
using AutoRepairShop.Core.Repositories;

namespace AutoRepairShop.Core.Services
{
    public class ProductService<TProductRepository>
        where TProductRepository : IRepository<Product>
    {

    }
}
