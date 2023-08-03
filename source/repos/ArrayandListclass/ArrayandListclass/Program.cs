using System;
using System.Collections.Generic;

namespace ArrayandListclass
{
    class Program
    {
        static void Main(string[] args)
        {



            int countodd = 0;
            int counteven = 0;

            string odd = string.Empty;
            string even = string.Empty;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());


                if (number % 2 == 0)
                {
                    
                    if (even==" ")
                    {
                        even = even + number;
                    }
                    else
                    {
                        even = even + "," + number;
                    }
                    counteven++;
                }

                else if (number % 2 != 0)
                {
                    countodd++;
                    if (odd=="")
                    {
                        odd = odd + number;
                    }
                    else
                    {
                        odd = odd + "," + number;
                    }


                }


            }

            Console.WriteLine($"The occurs number of odd is {odd} and number  of count is {countodd}");
            Console.WriteLine($"Thre occurs number of even is {even} and number of count is {counteven}");



        }
    }
}
