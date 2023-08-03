 using System;

namespace Question_14_chapter_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your number to decimal  ");
            int hexadecimal = int.Parse(Console.ReadLine());

            string x = Convert.ToString(hexadecimal, 16).ToUpper();

            Console.WriteLine($" The number {hexadecimal} from decimal to hexadecimal is {x}");

        }
    }
}
