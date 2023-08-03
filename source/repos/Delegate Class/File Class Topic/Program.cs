using System;
using System.IO;
using System.Collections.Generic;
namespace File_Class_Topic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() {"ola","Ade","olatunji","Bola","Bolu"};
            
            var students = new List<Student>()
            {
                new Student
                {
                    Name = "Ola",
                    Age = 20,
                    Gender = "Male"
                },

                new Student
                {
                    Name = "Ade",
                    Age= 21,
                    Gender = "Male"

                },

                new Student
                {
                    Name = "Olatunji",
                    Age= 15,
                    Gender = "Male"

                },

                new Student
                {
                    Name = "Bola",
                    Age= 21,
                    Gender = "Female"

                },

                new Student
                {
                    Name = "Bolu",
                    Age= 19,
                    Gender = "Female"

                },

                
            
            };


            PrintStudentThatIsB(names);

        }





        static void PrintStudentThatIsB(List <string> names)
        {
            foreach (var item in names)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
        }


        static void PrintDeligate()
        {

        }


    }
}
