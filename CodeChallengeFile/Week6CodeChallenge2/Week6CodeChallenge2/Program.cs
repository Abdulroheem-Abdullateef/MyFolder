using System;

namespace Week6CodeChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] num = new int[] { 3, 30, 34, 5, 9 };
            //string a = num.ToString();

            //for (int i = 0; i < a.Length; i++)
            //{
            //    for (int j = i+1; j < a.Length; j--)
            //    {
            //        if (a.Length )
            //        {

            //        }
            //    }
            //} 


            Console.WriteLine("Hello World!");
            int number = int.Parse(Console.ReadLine());
            int remainder=0;
            int reverse =0;
            // decimal a = 1;

            //while (true)
            //{
            //    if (number <=1)
            //    {
            //        break;
            //    }

            //    a*=number;
            //    number--;
            //}
            //Console.WriteLine($" N! = {a} ");

            while (number > 0 )
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;
            }
            Console.WriteLine(reverse);
        }
    }
}
