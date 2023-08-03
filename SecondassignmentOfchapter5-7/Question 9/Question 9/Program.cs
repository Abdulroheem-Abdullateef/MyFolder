using System;

namespace Question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter second number");
            int number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter third number");
            int number3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter fourth number");
            int number4 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter fifth number");
            int number5 = int.Parse(Console.ReadLine());


            if (number1+number2==0)
            {
                Console.WriteLine($" = {number1} , {number2}");
            }
            

            
            if (number1 + number2 + number3 == 0)
            {
                Console.WriteLine($" {number1} , {number2} , {number3}");
            }



            if (number1 + number2 + number3 + number4 == 0)
            {
                Console.WriteLine($" = {number1} , {number2} , {number3} , {number4}");
            }


            if (number1 + number2 + number3 + number4 + number5 == 0)
            {
                Console.WriteLine($" {number1} , {number2} , {number3} , {number4} , {number5}");
            }

            if (number2 + number3  == 0)
            {
                Console.WriteLine($"{number2} , {number3}");
            }

            if (number2 + number3 + number4 == 0)
            {
                Console.WriteLine($" {number2} , {number3} , {number4}");
            }


            if (number2 + number3 + number4 +  number5 == 0)
            {
                Console.WriteLine($" {number2} , {number3} , {number4} , {number5}");
            }

            if (number3 + number4 == 0)
            {
                Console.WriteLine($"{number3} , {number4}");
            }

            if (number3 + number4 + number5 == 0)
            {
                Console.WriteLine($" {number3} , {number4} , {number5}");
            }

            if (number4 + number5 == 0)
            {
                Console.WriteLine($" {number4} , {number5}");
            }

            else
            {
                Console.WriteLine($" number is not in subset");
            }


            



        }
    }
}
