using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_On_OOP_27_11_2021
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }
        
        public Person (string firstname, string lastname, string middlename)
        {
            FirstName = firstname;
            LastName = lastname;
            MiddleName = middlename;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"My Name is {FirstName} {LastName} {MiddleName}");
        }
       private class Human
       {

       }
    }
}
