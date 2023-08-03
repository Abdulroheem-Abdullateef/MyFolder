using System;

namespace Question_17_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;

                }

                else
                {
                    b %= a;
                }


                if (a == 0)
                {
                    Console.WriteLine(b);
                }

                else
                {
                    Console.WriteLine(a);

                }
            }
        }
    }
}
