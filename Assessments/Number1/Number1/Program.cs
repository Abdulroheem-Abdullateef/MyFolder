using System;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {23,45,67,98,65,33,455,34,44,22};
            int sum = 0;
            foreach (var item in array)
            {
                
                sum += item;
                
            }
            Console.WriteLine(sum);

        }
    }
}
