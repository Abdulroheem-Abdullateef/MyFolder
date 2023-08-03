using System;

namespace Question_17_Chapter_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer1");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter integer2");
            int number2 = int.Parse(Console.ReadLine());

            while (number!=0 && number2!=0)
            {
                if (number>number2)
                {
                    number %= number2;
                }

                else
                {
                    number2 %= number;
                }


                if (number==number2)
                {
                    Console.WriteLine(number2);
                }

                else
                {
                    Console.WriteLine(number);

                }
            }




        }
    }
}
