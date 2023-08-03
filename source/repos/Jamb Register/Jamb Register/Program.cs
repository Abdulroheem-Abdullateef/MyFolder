using System;
using System.Collections.Generic;

namespace Jamb_Register
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Student> student1 = new List<Student>();
            string registration = " ";
            string course = " ";
            string institution = " ";




            bool check = true;
            while (check)
            { 

                Console.WriteLine($"( Enter a number for registration between 1 to 5 )\n  1. For Registration  \n   2. Check Admission Status \n  3. Update Details \n  4. To Admit  Student \n 5. Exit");
                int reply = int.Parse(Console.ReadLine());

            
                        if (reply == 1)
                        {
                            
                            Console.WriteLine("Enter your name");
                            string firstname = Console.ReadLine();

                            Console.WriteLine("Enter your lastname");
                            string lastname = Console.ReadLine();

                            Console.WriteLine("Enter your Year of Birth");
                            int birth = int.Parse( Console.ReadLine());

                            Console.WriteLine("Enter your Gender");
                            string gender = Console.ReadLine();

                            Console.WriteLine("Enter your Institution");
                            string institutions = Console.ReadLine();

                            Console.WriteLine("Enter your Course");
                            string courses = Console.ReadLine();

                            int age = DateTime.Now.Year -  birth;
                            

                            if (age >= 18)
                            {
                               Student student = new Student(firstname,lastname,birth,gender,institutions,courses);
                               student1.Add(student);
   
                               Console.WriteLine($" Your Registration number is {student.GetRegNo()}");
                            }

                        }


                        else if (reply == 2)
                        {
                            
                           Console.WriteLine("Enter your registration number");
                           string register = Console.ReadLine();
                                foreach (var item in student1)
                                {
                               

                                    if (item.GetRegNo()==register)
                                    {
                                       
                                        item.SetIsAdmitted(true);
                                       Console.WriteLine($"{item.GetFirstName()} {item.GetLastName()} You Have Been Admitted");
                                        
                                        
                                    }

                                    else
                                    {
                                        Console.WriteLine($"{item.GetFirstName()} {item.GetLastName()} you have not been admited");
                                    }


                                }
                        }




                        else if (reply == 3)
                        {
                            Console.WriteLine("Enter your registration number");
                           string register = Console.ReadLine();

             
                                
                            foreach (var item in student1)
                            {
                                if (item.GetRegNo()==register)
                                {

                                    Console.WriteLine("Enter your first name:");
                                    string firstName = Console.ReadLine();
                                    item.SetFirstName(firstName);
                                

                                    Console.WriteLine("Enter your lastname");
                                    string lastname = Console.ReadLine();
                                    item.SetLastName(lastname);

                                    Console.WriteLine("Enter your Year of Birth");
                                    int birth = int.Parse(Console.ReadLine());
                                    item.SetYearOfBirth(birth);

                                    Console.WriteLine("Enter your Gender");
                                    string gender = Console.ReadLine();
                                    item.SetGender(gender);

                                    Console.WriteLine("Enter your Institution");
                                    string institutions = Console.ReadLine();
                                    item.SetInstitution(institution);

                                    Console.WriteLine("Enter your Course");
                                    string courses = Console.ReadLine();
                                    item.SetCourse(courses);





                                }
        
                            }

                        }

                        

                            else if (reply == 4)
                            {
                               Console.WriteLine(" Press 1 for Registration \n Press 2 by institution \n Press 3 by Course");
                               int respond = int.Parse(Console.ReadLine());
                                
                          
                              if (respond==1)
                              {
                                Console.WriteLine(" Enter Registration number");
                                 registration = Console.ReadLine();
                       
                              }

                              if (respond==2)
                              {
                                  Console.WriteLine(" Enter your institution");
                                  institution = Console.ReadLine();

                              }

                              if (respond==3)
                              {
                                  Console.WriteLine(" Enter your Course");
                                  course = Console.ReadLine();

                              }

                                
                                foreach (var item in student1)
                                {
                                    
                                    if (item.GetRegNo()==registration || item.GetCourse()==course || item.GetInstitution()==institution)
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
