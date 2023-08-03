using System;
using System.Collections.Generic;

namespace Week6CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> num = new List<string>();

            //int lenght = 0;
            //string reverse = "", remainder = "";

            //Console.WriteLine("Enter your number");
            //string number = Console.ReadLine();
            //lenght = number.Length - 1;

            //while (lenght>=0)
            //{
            //    reverse = reverse + number[lenght];
            //    lenght--;
            //}

            //Console.WriteLine(reverse);


            //int[] nums = { 10, 2 };
            //string b = " ", reverse = " ";

            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //int num = 1;
            //int sum = 1;
            //Console.Write("The sum 1");
            //while (num < n)
            //{
            //    num++;
            //    sum += num;
            //    Console.Write(" + " + num);
            //}
            //Console.WriteLine(" = " + sum);
            Console.WriteLine("Enter a number to reverse");
            int num = int.Parse(Console.ReadLine());

            int result = Reverse(num);
            Console.WriteLine($" your reverse number of {num} is {result}");
            static int Reverse(int number)
            {
                int remainder, reverse = 0;
                while (number > 0)
                {
                    remainder = number % 10;
                    reverse = (reverse * 10) + remainder;
                    number = number / 10;
                }
                return reverse;

            }


        }
    }
}
