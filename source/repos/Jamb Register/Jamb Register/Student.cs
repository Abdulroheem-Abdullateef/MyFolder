using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamb_Register
{
   public class Student
    {
        private string FirstName;
        private string LastName;
        private string RegNo;
        private int YearofBrith;
        private string Gender;
        private string Institution;
        private string Course;
        bool IsAdmitted;
         int Age;
        
 
        public Student(string firstname, string lastname,int yearofbirth, string gender, string institution,  string course)
        {
            FirstName = firstname;                                                                                                                                                                               
            LastName = lastname;
            RegNo = GenerateRegNo();
            YearofBrith = yearofbirth;
            Gender = gender;
            Institution = institution;
            Course = course;
            IsAdmitted = false;
            Age = Getage();
        }
        public string GenerateRegNo()
        {
            Random rmd = new Random();
            return $"JM{(rmd.Next(1000, 10000).ToString("0000"))}{(char)('A'+ rmd.Next(26))}{(char)('A' + rmd.Next(26))}";
        }

        public int Getage()
        {
            return DateTime.Now.Year - YearofBrith;

        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string firstname)
        {
            FirstName = firstname; 
        }
        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string lastname)
        {
            LastName = lastname;
        }
        public int GetYearOfBirth()
        {
            return YearofBrith;
        }
        public void SetYearOfBirth(int yearofbirth)
        {
            YearofBrith = yearofbirth;
        }
        public string GetGender()
        {
            return Gender;
        }
        public void SetGender(string gender)
        {
            Gender = gender;
        }
        public string GetInstitution()
        {
            return Institution;
        }
        public void SetInstitution(string institution)
        {
            Institution = institution;
        }
        public string GetCourse()
        {
            return Course;
        }
        public void SetCourse(string course)
        {
            Course = course;
        }
        public bool GetIsAdmitted()
        {
            return IsAdmitted;
        }

        public void SetIsAdmitted(bool isadmitted )
        {
           IsAdmitted=isadmitted;
        }
     
        
        public string GetRegNo()
        {
            return RegNo;
        }    
        
        
            
                
            
        

   }
}
