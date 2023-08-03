using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeOnJWT.Entities
{
    public class Teacher : User
    {
        public string StaffId { get; set; }
        public IList<Student> Students { get; set; }
    }
}
