using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Core.dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronomic { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }
        public int Role { get; set; }
        public string Login { get; set; }
        public string Hash { get; set; }
    }
}
