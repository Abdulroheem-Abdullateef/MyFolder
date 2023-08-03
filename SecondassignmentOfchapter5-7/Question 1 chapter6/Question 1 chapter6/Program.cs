using System;

namespace Question_1_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
