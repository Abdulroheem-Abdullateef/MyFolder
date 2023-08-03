using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTPractice.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
