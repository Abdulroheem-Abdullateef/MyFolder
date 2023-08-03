using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass2
{
    public class Person
    {
        public int Age { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }

        public Person( int age, string surname, string firstname)
        {
            Age = age;
            Surname = surname;
            FirstName = firstname;
        }
    }
}
