using System;

namespace My_Register
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine($"( Enter your age");
            int age = int.Parse(Console.ReadLine());

            age = DateTime.Now.Year - age;

            if (age <= 18)
            {
                Console.WriteLine(" You can now register");
            }

            bool check = true;
            while (check)
            {

                Console.WriteLine($"( Enter a number for registration between 1 to 5 )  1. For Registration  \n   2. Check Admission Status \n  3. Update Details \n  4. To Admit  Student \n 5. Exit");
                int reply = int.Parse(Console.ReadLine());





                if (reply == 1)
                {
                    Console.WriteLine("Enter your name");
                    string firstname = Console.ReadLine();

                    Console.WriteLine("Enter your lastname");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter your Year of Birth");
                    int birth = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your Gender");
                    string gender = Console.ReadLine();

                    Console.WriteLine("Enter your Institution");
                    string institutions = Console.ReadLine();

                    Console.WriteLine("Enter your Course");
                    string courses = Console.ReadLine();

                    int age = DateTime.Now.Year - birth;


                    if (age >= 18)
                    {
                        Student student = new Student(firstname, lastname, birth, gender, institutions, courses);
                        student1.Add(student);
                        Console.WriteLine(student.GenerateRegNo());
                    }

                }


                else if (reply == 2)
                {
                    bool admit = false;
                    Console.WriteLine("Enter your registration number");
                    string register = Console.ReadLine();
                    foreach (var item in student1)
                    {
                        if (item.GetIsAdmitted() == true && item.GenerateRegNo() == register)
                        {
                            Console.WriteLine($"{item.FirstName} {item.LastName} You Have Been Admitted");

                            admit = true;
                        }


                    }


                    if (!admit)
                    {
                        Console.WriteLine($" Sorry !!! You Haven't Been Admitted ");
                    }
                }




                else if (reply == 3)
                {

                }

                else if (reply == 4)
                {
                    Console.WriteLine(" Press 1 for Registration \n Press 2 by institution \n Press 3 by Course");
                    int respond = int.Parse(Console.ReadLine());


                    if (respond == 1)
                    {
                        Console.WriteLine(" Enter Registration number");
                        registration = Console.ReadLine();

                    }

                    if (respond == 2)
                    {
                        Console.WriteLine(" Enter your institution");
                        institution = Console.ReadLine();

                    }

                    if (respond == 3)
                    {
                        Console.WriteLine(" Enter your Course");
                        course = Console.ReadLine();

                    }

                    foreach (var item in student1)
                    {
                        if (item.GenerateRegNo() == registration || item.Course == course || item.Institution == institution)
                        {
                            item.SetIsAdmitted(true);
                        }
                    }

                }

                else if (reply == 5)
                {
                    check = false;
                }

            }
        }
    }
}
