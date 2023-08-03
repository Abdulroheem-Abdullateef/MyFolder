using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_On_OOP_27_11_2021
{
    class Student:Person
    {
        
        public string SurName;


        public Student(string surname,string firstname,string lastname,string middlename) : base(firstname,lastname,middlename)
        {
            SurName = surname;
            SurName += 1;
        }

       
    }
}
