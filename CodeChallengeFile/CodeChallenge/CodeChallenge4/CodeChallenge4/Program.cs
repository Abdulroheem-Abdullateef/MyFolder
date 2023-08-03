using System;

namespace CodeChallenge4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("your size of your array");
            int size = int.Parse(Console.ReadLine());

            int []  array = new int [size];

            Console.WriteLine("your target number :");
            int target = int.Parse(Console.ReadLine());

           

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter your element: ");
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int j = 0; j < array.Length; j++)
            {
                for (int k =j+1; k < array.Length; k++)
                {
                    if (array[j] + array[k] == target )
                    {
                        Console.WriteLine($"Output : {j},{k}");
                    }
                }
            }
        }
    }
}
