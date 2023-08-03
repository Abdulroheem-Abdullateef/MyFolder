using System;

namespace Question_9_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            int temp = 1;

            Console.WriteLine("Enter your number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int number2 = int.Parse(Console.ReadLine());

            for (int i = 1; 1 < number1; i++)
            {
                
                
                    temp *= i / number2;
                    sum += temp;

                    Console.WriteLine(sum);
                

                
            }
            

        }
    }
}
