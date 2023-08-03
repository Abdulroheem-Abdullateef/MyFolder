using System;

namespace QUESTION_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO CHECK THE COMPARISM OF A NUMBER WITH NUMBERS");
            int [] input = {2,7,9,12,10,76,4,78,9,2,8};
            Console.WriteLine("enter the position of number you intend to compare");
            int numberCompare = int.Parse(Console.ReadLine());

            bool final = CompareNumbers(input, numberCompare);
            Console.WriteLine($"{final}");

            



        }
        public static bool CompareNumbers(int [] a, int num)
        {
            bool check = true;
            if ( a[num] > a[num+1] && a[num] > a[num-1] )
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }
        
    }
}
