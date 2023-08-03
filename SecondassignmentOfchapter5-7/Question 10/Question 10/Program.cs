using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 and 9");
            int input = int.Parse(Console.ReadLine());

            if (input > 1 && input <= 3)
            {
                Console.WriteLine($" your point is {input*10}");
            }

            if (input >= 4 && input <= 6)
            {
                Console.WriteLine($" your point is {input * 100}");
            }

            if (input >= 7 && input <= 9)
            {
                Console.WriteLine($" your point is {input * 1000}");
            }

            else
            {
                Console.WriteLine($" Error message");
            }

            
            

            
        }
    }
}
