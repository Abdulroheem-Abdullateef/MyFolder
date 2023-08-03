using System;

namespace Question_12_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter number");
            int number = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(number,2);
            Console.WriteLine($" {binary}");


        }
    }
}
