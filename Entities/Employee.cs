using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int Age { get; set; }
        public DateOnly DateOfBirthday { get; set; }
    }
}
