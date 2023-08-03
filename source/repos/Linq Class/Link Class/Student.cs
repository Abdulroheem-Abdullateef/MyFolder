using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Class
{
    class Student
    {
       
        public int ID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public List<string> Subjects { get; set; }

        public static List<Student> GetStudents()
        {

            List<Student> students = new List<Student>()
            {
                new Student(){ID = 1, Gender = "Male", Name = "Ola", Subjects = {"C#","Java","Python" } },
                new Student(){ID = 2, Gender = "Male", Name = "Tunde", Subjects = {"Java", "Java script" } },
                new Student(){ID = 3, Gender = "Female", Name = "Olamide", Subjects = {"C#", "Java","Data Base" } },
                new Student(){ID = 4, Gender = "Female", Name = "Adeola", Subjects = { "Jago", "enum","SQl"} },
                new Student(){ID = 5, Gender = "Male", Name = "Olakunle", Subjects = { "postgry SQL", "HTML","CSS"} }
            };


            return students;
        }


    }


    class StudentInfo
    {

        public string FirstName { get; set; }
        public string Sex { get; set; }


    }
}