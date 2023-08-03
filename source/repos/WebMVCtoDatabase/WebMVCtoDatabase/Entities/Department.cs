using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCConnect.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
