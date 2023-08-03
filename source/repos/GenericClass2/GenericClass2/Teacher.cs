using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class Teacher : Person
    {
        public string StaffNo { get; set; }
        public string Tittle { get; set; }

        public Teacher(string staffno, string tittle,int age,string surname,string firstname) :base(age,surname,firstname)
        {
            StaffNo = staffno;
            Tittle = tittle;
        }

    }
}
