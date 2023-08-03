using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your num1");
            int num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your num2");
            int num2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your num3");
            int num3 = int.Parse(Console.ReadLine());

            int average = num1 + num2 + num3 / 3;


            Console.WriteLine($"your {num1} , {num2} and {num3} is {average}");

            
        }
    }
}
