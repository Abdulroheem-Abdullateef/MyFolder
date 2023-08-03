using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            

            int average = 0;

            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your score");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
                average += number;
            }

            int lowest = array[0];
            int largerst = 0;


            foreach (var score in array)
            {
                if (score>largerst)
                {
                    largerst = score;
            
                }

                if (lowest>score)
                {
                    lowest = score;
                }
            
            }

            int result = average / 5;

            Console.WriteLine($" the lowest is {lowest} and the largest {largerst} and average {result}");

            Console.WriteLine( @"The nameof man");

        }
    }
}
