using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Jamp_App
{
    class Register
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string MiddleName { get; set; }

        private string Course { get; set; }
        private string Institution { get; set; }
        private int YearOfBirth { get; set; }
        
        private string Gender { get; set; }
        private string RegNo { get; set; }

        bool IsAdmitted;

        List<string> StudentRecord = new List<string>();

        public Register(string firstname,string lastname, string middlename, string course, string institution,string gender,int yearofbirth )
        {
            FirstName = firstname;
            LastName = lastname;
            MiddleName = middlename;
            Course = course;
            Institution = institution;
            YearOfBirth = yearofbirth;
            Gender = gender;
            IsAdmitted = false;
            RegNo = GenerateRegNo();

        }

        public string GenerateRegNo()
        {
            Random random = new Random();
            return $"JM{(random.Next(1000, 10000).ToString("0000"))}{(char)'A'+ random.Next(0,26)}{(char)random.Next(0,26)}";
        }


        public bool IsAddmit()
        {
           return IsAdmitted = true;
        }
    }

    public enum Gender
    {
        Male = 1,
        Female


    }


}
