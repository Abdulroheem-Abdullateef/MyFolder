using System;

namespace Week5CodeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] root =  { 5,4,8,11,0,13,4,7,2,0,0,5,1};
            int number = 0;
            Console.WriteLine("Enter your target");
            int target = int.Parse(Console.ReadLine());

            for (int i = 1; i < root.Length; i++)
            {
                for (int j = i ; j < root.Length; j++)
                {
                    if (root[i] + root[j] == target )
                    {

                        number++;
                        
                    }
                }
            }
            Console.WriteLine(number);
        }
    }
}
