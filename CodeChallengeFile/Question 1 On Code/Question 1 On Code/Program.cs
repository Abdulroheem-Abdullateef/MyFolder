using System;
using System.Collections.Generic;

namespace Question_1_On_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine($" Enter your number of the array length {1+i} ");
                num[i] = int.Parse(Console.ReadLine());

            }

            MiniMaxSum(num);




        }


        static void  MiniMaxSum(int [] array)
        {
            Array.Sort(array);

            long maximum = 0;
            long minimum = 0;

          
            for (int i = 0; i  <= array.Length -2; i++)
            {
                minimum += array[i];   
            }


            for (int j  = 1; j <= array.Length - 1; j++)
            {
                maximum += array[j];
            }


            Console.WriteLine($"{minimum}          {maximum}");
        } 

        
    }
}
                                                              