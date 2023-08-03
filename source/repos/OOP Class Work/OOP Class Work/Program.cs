using System;

namespace OOP_Class_Work
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Setname("shola");
            student.Setage(23);
            student.PrintStudentDetails();
            
            int a = 5; 
            int b = 7; 
            string sum = "Sum = " + (a + b); 
            Console.WriteLine(sum); 
            String incorrect = "Sum = " + a + b; 
            Console.WriteLine(incorrect);
            Console.WriteLine( "Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");
        
        }
    }




    class Student
    {
        private string name;
        private int age;


        public string Getname()
        {
            return name;
        }

        public void Setname(string name)
        {
            this.name = name;
        } 


        public int Getage()
        {
            return age;
        } 

        public void Setage(int age)
        {
            this.age = age;
        }


        public void PrintStudentDetails()
        {
            Console.WriteLine($"{name} is {age} years old");
            
        }

    }
    


}
