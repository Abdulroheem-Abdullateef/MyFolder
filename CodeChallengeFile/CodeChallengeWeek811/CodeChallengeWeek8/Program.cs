using System;

namespace CodeChallengeWeek8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = Staircase(8);
            Console.WriteLine(x);

            


        }

        public static int Staircase(int number)
        {
            
            int max, c;
            int l = 0, row = number;

            while (l <= row)
            {
                max = l + (row - l ) / 2;
                c = max * (max + 1) / 2;

                if (c == number)
                {
                    Console.WriteLine(max);
                }

                if (number < c)
                {
                    row = max - 1;

                }
                else
                {
                    l = max + 1;
                }
            }

            return row;
        }
    }
}
