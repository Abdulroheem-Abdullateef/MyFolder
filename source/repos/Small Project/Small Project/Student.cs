using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Project
{
    class Student
    {

        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public int Phoneumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string RegNumber { get; set; }
        public string Date { get; set; }

        public Student(string firstName, string lastname, int phoneumber, string gender, string email, string regNumber, string date)
        {
            FirstName = firstName;
            Lastname = lastname;
            Phoneumber = phoneumber;
            Gender = gender;
            Email = email;
            RegNumber = regNumber;
            Date = date;
        }

        private Student(string firstName, string lastname, int phoneumber, string gender, string email, string date)
        {
            FirstName = firstName;
            Lastname = lastname;
            Phoneumber = phoneumber;
            Gender = gender;
            Email = email;
            Date = date;

        }
    }
}
