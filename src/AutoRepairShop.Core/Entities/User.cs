using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Entities
{
    public class User : IEntity, IUniqNamed
    {
        public int Id { get; set; }
        public string UniqName { get; set; }
        public string Hash { get; set; }
        public int RoleId { get; set; }
        public int InfoId { get; set; }

    }
}
