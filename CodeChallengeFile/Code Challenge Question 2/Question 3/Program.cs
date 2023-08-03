
using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Console.WriteLine(CounttingValleys(8,"DDUUUUDD"));

            



        }


        public static int CounttingValleys(int step, string path)
        {
            int result = 0;
            int hill = 0;
            for (int i = 0; i < step; i++)
            {
                if (path[i] == 'U')
                {
                    hill++;
                }
                else
                {
                    hill--;
                }

                if (hill == 0 && path[i] == 'U')
                {
                    result++;
                }

                
            }

            return result;
        }

    }
}
