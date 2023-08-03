using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeOnJWT.Entities
{
    public class Student : User
    {
        public string MatricNumber { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
