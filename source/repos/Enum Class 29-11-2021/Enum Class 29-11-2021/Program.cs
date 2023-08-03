
using System;

namespace Enum_Class_29_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enum

            var java = new Person("Amotu",MaritalStatus.Single);
            var python = new Person("SalamBhai",MaritalStatus.Married);
            var node = new Person("Tola",MaritalStatus.Divorced);







            Person[] People = new Person[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter your name: ");
                var name = Console.ReadLine();
                Console.Write("Enter your marital status(1 for single, 2 for married and 3 for divorce): ");
                int status = int.Parse(Console.ReadLine());
                People[i] = new Person(name, (MaritalStatus)status);
            }

            foreach(var item in People)
            {
                if (item.Status == MaritalStatus.Single)
                {
                    Console.WriteLine($"{item.Name} is single.");
                }
            }


            
        }
    }


    public class Person
    {
        
        public string Name { get; set; }

        public MaritalStatus Status { get; set; }

        public Person(string name, MaritalStatus status)
        {
            Name = name;
            Status = status;
        }

    }

    public enum MaritalStatus
    {
        Single = 1,
        Married,
        Divorced,
    }

    class Student
    {
        public string Firstname{ get; set; }
        public string Lastname { get; set; }

        public Student(string firstname,string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

        }   
    }

    public enum Name
    {
        name=1,
        last,
    }
   


}
