using System;

namespace Question_11_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong value = 0;
            Console.WriteLine("Enter a number");
            ulong number = ulong.Parse(Console.ReadLine());

            for (ulong i= number-1; i > 0; i--)
            {
                number *= i;


                Console.WriteLine($"N! is {number} ");
                if (number % 10 ==10)
                {
                    number /= 10;
                    value++;

                    Console.WriteLine(value);
                }

                
            }


         


        }
    }
}
