using System;

namespace QUESTION_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO FIND NUMBERS OF TIMES A NUMBER CAN BE FOUND IN A GIVEN ARRAY");
            Console.WriteLine("enter the numbers");
            int num = int.Parse(Console.ReadLine());
            int [] array = new int [num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter the numbers");
                int numbers = int.Parse(Console.ReadLine());
                array[i] = numbers;
            }
            Console.WriteLine("enter a number to know the occurence of numbers");
            int d = int.Parse(Console.ReadLine());
            int c = OccurenceNumber(d,array);
            Console.WriteLine($"The occurence of number {d} in the set of numbers is {c} times");
        }
            public static int OccurenceNumber(int a, int [] input)
            {
                int x = 0;
                foreach (var item in input)
                {
                    if (a == item)
                    {
                        x++;
                    }

                }
                return x;
            }



    }
}
