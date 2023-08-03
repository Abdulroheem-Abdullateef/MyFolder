using System;

namespace Number10
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int count = 0;
            for (; ; )
            {
                Console.WriteLine("Enter a number : and, use (0) to stop.");
                int number = int.Parse(Console.ReadLine());
                if (number>max)
                {
                    max = number;
                    count = 1;
                }
                else if (number==max)
                {
                    count++;
                }

                if (number==0)
                {
                    break;
                }
                
            }


            Console.WriteLine($"The largest number is {max} and the occurence is {count}");
        }
    }
}
