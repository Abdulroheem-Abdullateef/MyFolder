using System;

namespace QUESTION_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO FIND THE BIGGEST NUMBER IN ARRAY");
            Console.WriteLine("enter the size of the number you want to input");
            int size = int.Parse(Console.ReadLine());
            int[] data = new int [size];
            for (int i = 0; i<data.Length; i++)
            {
                Console.WriteLine("enter number:");
                int number = int.Parse(Console.ReadLine());
                data[i] = number;
            }
            int largest = HighestNumber(data);
            Console.WriteLine($"The largest number of the array is {largest}");

        }
            public static int HighestNumber(int [] a)
            {
                int x = 0;
                foreach (var item in a)
                {
                   for (int y=1; y<a.Length; y++)
                   {
                       if (a[x]<a[y])
                       {
                           a[x]=a[x]+a[y];
                           a[y]=a[x]-a[y];
                           a[x]=a[x]-a[y];
                       }
                       x++;
                   } 
                   x=0;
                }
                foreach(var item in a )
                {
                    Console.WriteLine (item);
                }
                int max = a[0];
                return max;
            }
    }
}
