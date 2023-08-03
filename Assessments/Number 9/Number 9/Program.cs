using System;

namespace Number_9
{
    class Program
    {
        static void Main(string[] args)
        {

            

            for (int i = 1; i <= 10; i++)
            {
                double mile = 1.609;
                double kilogram = mile * i;

                Console.WriteLine($"mile   kilogram");
                Console.WriteLine($"{i}        {kilogram} ");
            }
       
        }
    }
}
