using System;

namespace Question_1_chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] array = new int [20];

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = i * 5;

                Console.WriteLine($"  {array[i]}");
            }
        
        }
    }
}
