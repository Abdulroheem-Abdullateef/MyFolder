using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCConnect.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
