using System;

namespace Question_5_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

           double value1 = 0;
            double value2 = 1;
            


            Console.WriteLine("r1");

            Console.WriteLine("r2"); 

            Console.WriteLine("Enter your number");
            double n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double value3 = value1 + value2;

                value1 = value2;
                value2 = value3;


                Console.WriteLine(value3);

            }


        }
    }
}
