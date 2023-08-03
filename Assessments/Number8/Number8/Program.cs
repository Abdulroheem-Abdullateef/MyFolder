using System;

namespace Number8
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilogram =2.205;

            for (int i = 1; i <=199; i+=2)
            {
                double miles = kilogram*i;
                Console.WriteLine($"{i}kilogram and pounds:{miles}");
            }
        }
    }
}
