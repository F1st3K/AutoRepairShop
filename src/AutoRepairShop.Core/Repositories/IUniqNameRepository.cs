using AutoRepairShop.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Core.Repositories
{
    interface IUniqNameRepository<TEntity>
        where TEntity : IUniqNamed
    {
        bool TryGetId(string uname, out int id);
        bool IsUniq(string uname);
    }
}
