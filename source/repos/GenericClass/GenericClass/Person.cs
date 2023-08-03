using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
   
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int age, string name)
        {
            Name = name;
            Age = age;
        }


        public void Get(string name)
        {
            Name = name;
        }

        public string Set(string name)
        {
            return name;
        }

    }
}
