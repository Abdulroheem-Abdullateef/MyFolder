using System;

namespace largeInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            int[] array2 = new int[number];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
               
            }
            int answer = largeInteger(array2);
            Console.WriteLine(answer);


            static int largeInteger(int[] array)
            {
                int max = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                       max = array[i] + 1;
                        
                    }
                    
                }

                return max;
            }


        }
    }
}
