using System;

namespace QUESTION_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO SHOW THE LARGEST BETWEEN TWO NUMBERS:");
            Console.WriteLine("enter your first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your second number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your three number:");
            int z = int.Parse(Console.ReadLine());
            int t =AddUpNumbers(AddUpNumbers(x,y),z);
            Console.WriteLine($"The biggest number between {x} {y} {z} is {t}");


        }

        public static int AddUpNumbers(int a, int b)
        {
            int max=0;
            if (a>b)
            {
               max = a; 
            }
            else  
            {
                max = b;
            }
            return max;
        }
    }
}
