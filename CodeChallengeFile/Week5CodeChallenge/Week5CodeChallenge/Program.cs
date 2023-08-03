using System;

namespace Week5CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int[] expectednums = { 1, 1, 1, 2, 2, 3};

            int  x = RemoveDublicate(expectednums);
            Console.WriteLine(x);
            
        }

        public static int RemoveDublicate(int [] array)
        {

             int sum =  0 ;
            int duplicate = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]  == duplicate  )
                {
                    Console.WriteLine($"{array}"); ;
                }
            }
            return sum;
        }
    }
}
