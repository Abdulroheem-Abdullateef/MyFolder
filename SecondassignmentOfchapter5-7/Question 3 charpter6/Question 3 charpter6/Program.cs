using System;

namespace Question_3_charpter6
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 0;
            int largest = 0;
            

            Console.WriteLine("Enter a number to know your largest and lowest");
            int number = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter second number");
                int number2 = int.Parse(Console.ReadLine());

                if (number2 > largest)
                {
                    largest = number;
                }

                else if (number2 < largest)
                {
                    lowest = number2;
                }



            }
            Console.WriteLine($" The largest is {largest} and the lowest is {lowest}");
        }
    }
}
