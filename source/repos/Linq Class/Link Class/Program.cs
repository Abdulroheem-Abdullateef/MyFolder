using System;
using System.Linq;
using System.Collections.Generic;

namespace Link_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> numbers = new List<int>()
            // {
            //    -1,-2,-3,-4,-5,-6,-7,0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16
            // };

            //initialize.
            //condition.
            //selection.

            // var result = from number in numbers where number < 6 select number;
            // foreach (var num in result)
            // {
            //     Console.WriteLine(num);
            // }

        //    var sort = from num in numbers where num >= 7 select num;
        //    foreach (var item in sort)
        //    {
        //     Console.WriteLine(item);
        //    } 


            // List<string> _names = new List<string>()
            // {
            //     "Ade", "Olu", "Bola","Ahmad","Ademola","Adebayo", "Abdullah", "Alfa monsur Ahamad"
            // };
            // List<string> storeNameWith = new List<string>();

            //     var names = from name in _names where name.StartsWith('A') select name;
            //     foreach (var name in names)
            //     {
            //         storeNameWith.Add(name);

            //     }

            //    foreach (var item in storeNameWith)
            //    {
            //        Console.WriteLine(item);
            //    }


            // for (int i = 0; i < _names.Count(); i++)
            // {
            //     if (_names[i].StartsWith('A'))
            //     {
            //         storeNameWith.Add(_names[i]);

            //         foreach (var item in storeNameWith)
            //         {
            //             Console.WriteLine(item);
            //         }
            //     }

            //     else
            //     {
            //         Console.WriteLine($"{_names[i]}");
            //     }

            // }


            // var selects = numbers.Where(result => result > 7);
            // foreach (var numb in selects)
            // {
            //     Console.WriteLine(numb);
            // }


            List<Student> students = new List<Student>()
            {
                new Student() { ID = 1, Gender = "Male", Name = "Ola", Subjects = new List<string> { "C#", "Java", "Python" } },
                new Student() { ID = 2, Gender = "Male", Name = "Tunde", Subjects = new List<string> { "Java", "Java scerit" } },
                new Student() { ID = 3, Gender = "Female", Name = "Olamide", Subjects = new List<string> { "C#", "Java", "Data Base" } },
                new Student() { ID = 4, Gender = "Female", Name = "Adeola", Subjects = new List<string> { "Jago", "enum", "SQl" } },
                new Student() { ID = 5, Gender = "Male", Name = "Olakunle", Subjects = new List<string> { "postgry SQL", "HTML", "CSS" } }
            };






            var maleStudents = from student in students where student.Gender == "Male" select student.Name;
            foreach (var male in maleStudents)
            {
                Console.WriteLine(male);
            }


            // var malestudentsid = from student in students where student.Gender == "Male" select student.ID;
            // foreach (var male in malestudentsid)
            // {
            //     Console.WriteLine(male);
            // }


            // var femalestudents = students.Where(s => s.Gender == "Female").Select(s => new
            // {
            //     Unique = s.ID,
            //     FirstName = s.Name,
            //     Sex = s.Gender,
            //     Student = String.Join(',',s.Subjects)
            // });

            // foreach (var female in femalestudents)
            // {
            //     Console.WriteLine($" Your Name {female} ");
            // }



            // anominous

            // var femalestudents = students.Where(s => s.Gender == "Female").SelectMany(stud => stud.Subjects,(students,subject)=>new
            // {
            //     Unique = students.ID,
            //     FirstName = students.Name,
            //     Sex = students.Gender,
            //     Subject = subject
            // });

            //foreach (var female in femalestudents)
            //{
            //    Console.WriteLine($" Your Name: {female.FirstName} Gender: {female.Subject} ");
            //}

            // foreach (var item in Student.GetStudents())
            // {
            //     Console.WriteLine(item.Subjects);
            // }



            // IEnumerable<Student> students1 = students.Where(s => s.Gender == "Female").Select(s => new Student
            // {
            //     ID = s.ID,
            //     Name = s.Name,
            //     Gender = s.Gender
            // });

            // foreach (var female in students1)
            // {
            //     Console.WriteLine($" Your ID is:{female.ID}    Your Name is:{female.Name}  ");
            // }









            // IEnumerable<StudentInfo> students12 = students.Where(s => s.Gender == "Male").Select(s => new StudentInfo
            // {

            //     FirstName = s.Name,
            //     Sex = s.Gender
            // });

            // foreach (var female in students12)
            // {
            //     Console.WriteLine($" Your Name is:{female.FirstName}    Your Sex is:{female.Sex} ");
            // }

            // Distint

            // var malestudentsids = from student in students where student.Gender == "Male" select student.ID;

            // filter operator

            // List<object> items = new List<object>()
            // {
            //     1,"Ade", 47,"Tolu",44,"Shole",23,"tola",2.4,789.9,778
            // };

            // var ints = items.OfType<int>();
            // var mystrings = items.OfType<string>();
            // var mydouble = items.OfType<double>();
            // var myints  = items.OfType<int>().Where(x => x > 50 );

            // foreach (var x in mystrings)
            // {
            //     Console.WriteLine(x);
            // }


            //int[] setofint = { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var setofstring = new List<string>() { "Femi", "femi", "USA", "usa", "uk","UK" };

            //var myDistint = setofint.Distinct();
            //var mystring = setofstring.Distinct(StringComparer.OrdinalIgnoreCase);

            //foreach (var item in mystring)
            //{
            //    Console.WriteLine(item);
            //}

            // Expect

            //var setofint1 = new List<int>(){ 1, 1, 2, 3, 4, 5, 6, 7, 8, 9,23,21 };
            //var setofint2 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 21,34,22,11 };
            //// var setofstrings = new List<string>() { "Femi", "femi", "USA", "usa", "uk", "UK" };

            //var queryexcept = setofint2.Except(setofint1);

            //foreach (var item in queryexcept)
            //{
            //    Console.WriteLine(item);
            //}

            //// Union

            //var setofint12 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 21 };
            //var setofint23 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 21, 34, 22, 11 };

            //var unions = setofint12.Union(setofint23);

            //foreach (var item in unions)
            //{
            //    Console.WriteLine(item);
            //}

            //// interset

            //var intersetofint12 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 21 };
            //var intersetofint23 = new List<int>() { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 23, 21, 34, 22, 11 };

            //var interset = intersetofint12.Intersect(intersetofint23);

            //foreach (var item in interset)
            //{
            //    Console.WriteLine(item);
            //}










        }
    }


}
