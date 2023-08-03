using System;

namespace CodeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(" Enter a number : ");
            int array = int.Parse(Console.ReadLine());


            int[] arrays = new int[array];
            int minimum = 0;

            for (int i = 0; i < arrays.Length; i++)
            {
               
                for (int j = i + 1 ; j <arrays.Length; j++)
                {
                    if (arrays[i] == arrays [j] )
                    {
                      int x =  Math.Abs(j - i);
                        minimum++;

                        Console.Write($"{x}");
                    }
                    
                }
            }


        }
    }
}
