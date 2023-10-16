using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Entities
{
    public class UserInfo : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public string DOB { get; set; }
        public string Phone { get; set; }
    }
}
