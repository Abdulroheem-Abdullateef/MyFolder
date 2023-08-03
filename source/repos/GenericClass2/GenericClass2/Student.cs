using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public string Level { get; set; }

        public Student(int studentid, string level,int age,string surname,string firstname) :base(age,surname,firstname)
        {
            StudentId = studentid;
            Level = level;
        }

    }
}
