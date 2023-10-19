using AutoRepairShop.Core.Entities.Interfaces;

namespace AutoRepairShop.Core.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        
        public int UserInfoId { get; set; }

        public float Price { get; set; }
    }
}
