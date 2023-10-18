using AutoRepairShop.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Core.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int CategoryId { get; set; }
        public int ManufacturerId { get; set; }
        public int UnitId { get; set; }
        public int Count { get; set; }
        public float Discount { get; set; }
        public float Price { get; set; }
    }
}
