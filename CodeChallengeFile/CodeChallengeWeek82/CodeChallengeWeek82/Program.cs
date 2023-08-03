using System;

namespace CodeChallengeWeek82
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Stemps(5);
            Console.WriteLine(x);


        }

        public static int Stemps( int number)
        {
            int stem = 0;
            int count = 0;
            for (int i = 1; i < number; i++)
            {
                stem += i;

                if (stem <=  number)
                { 
                    count++;

                }

                if (stem > number)
                {
                    break;
                }


            }
            return count;
            
        }
    }
}
