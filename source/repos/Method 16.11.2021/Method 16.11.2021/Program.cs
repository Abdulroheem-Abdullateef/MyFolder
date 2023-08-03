using System;

namespace Method_16._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your number");
                array[i] = int.Parse(Console.ReadLine());

                
            }

            Console.WriteLine(Mean(array));


        }       



            public static int Sum(int [] number)
            {
                int sum = 0;
                
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i];
                }
                   return sum;

            }
         

        public static double Mean(int [] a)
        {
            int sum = Sum(a);
            double average = (double)sum / a.Length;
            return average;
        }
         
    }
}
