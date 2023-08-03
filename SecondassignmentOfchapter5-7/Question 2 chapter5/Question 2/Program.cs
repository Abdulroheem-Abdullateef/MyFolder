using System;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.Write a program that shows the sign(+ or -) of the product of three real
            //numbers, without calculating it.Use a sequence of if operators.

            Console.WriteLine("Enter your first sign (+ or -) in  number ");
            int sign1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your second sign (+ or -) in  number ");
            int sign2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your third sign (+ or -) in  number ");
            int sign3 = int.Parse(Console.ReadLine());


            if (sign1 < 0 && sign2 < 0 && sign3 > 0)
            {
                Console.WriteLine("you have (+)");
            }

            else if (sign1 < 0 && sign2 > 0 && sign3 < 0)
            {
                Console.WriteLine("you have (+)");
            }


            else if (sign1 > 0 && sign2 < 0 && sign3 < 0)
            {
                Console.WriteLine("you have (+)");
            }

            else if (sign1 > 0 && sign2 < 0 && sign3 < 0)
            {
                Console.WriteLine("you have (-)");
            }

            else if (sign1 > 0 && sign2 < 0 && sign3 < 0)
            {
                Console.WriteLine("you have (-)");
            }

            else if (sign1 < 0 && sign2 > 0 && sign3 < 0)
            {
                Console.WriteLine("you have (-)");
            }

            else if (sign1 <= 0 && sign2 <= 0 && sign3 <= 0)
            {
                Console.WriteLine("you have (-)");
            }

            else if (sign1 > 0 && sign2 > 0 && sign3 > 0)
            {
                Console.WriteLine("you have (+)");
            }







        }
    }
}
