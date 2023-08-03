using System;

namespace Question_13_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter binary number between 0 and 1 : ");
            int number = int.Parse(Console.ReadLine());
            
            int deci  = Convert.ToInt32(number.ToString(), 2);
            Console.WriteLine($" The binary number of {number} to decimal is  {deci}");
        } 
    }
}