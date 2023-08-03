using System;

namespace Test_On_OOP_27_11_2021
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Person person = new Person("Oladele", "ola", "Ade");
            //person.PrintInfo();
            //Student student = new Student("jhhc","djids","djhdd","djdjd");

            var c = new Circle(10);
            var area = c.GetArea();
            Console.WriteLine(area);
            
        }
    }
}
