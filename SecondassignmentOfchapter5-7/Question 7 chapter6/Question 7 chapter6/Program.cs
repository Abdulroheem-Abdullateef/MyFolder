using System;

namespace Question_7_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first number for factorial N ");
            ulong factorialN = ulong.Parse(Console.ReadLine());


            Console.WriteLine("Enter first number for factorial K ");
            ulong factorialK = ulong.Parse(Console.ReadLine());

            ulong difference = factorialN - factorialK;


            for (ulong i = factorialN - 1; i > 0; i--)
            {
                factorialN *= i;
            }

            for (ulong i = factorialK - 1; i > 0; i--)
            {
                factorialK *= i;
            }
                
            
            for (ulong i = difference - 1; i > 0; i--)
            {
                difference *= i;
            
          }
            Console.WriteLine("Result is {0}", factorialN * factorialK / difference);

        }
    }
}
