using System;

namespace Question_15_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int number = int.Parse(Console.ReadLine());

            string value = Convert.ToString(Convert.ToInt32(number),16);

            Console.WriteLine(value);
        }
    }
}
