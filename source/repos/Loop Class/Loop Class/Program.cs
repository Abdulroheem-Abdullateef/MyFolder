using System;

namespace Loop_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print all even number 1 to 100");

        
            for (int i = 2; i <= 100; i++)
            {
                bool check = true;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        check = false;
                        break;
                    }


                }

                if (check)
                {
                    Console.WriteLine(i);
                }



            }



        }
    }
}
