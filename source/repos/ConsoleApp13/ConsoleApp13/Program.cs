using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
             /*int h = 7;
             while(h >= -14)
             {
                 Console.WriteLine(h);
                 h -= 4;
             }

                int r = -7;
             do
             {
                 Console.WriteLine(r);
                 r += 5;
             } while (r < 30);

            Console.Write(" Kindly enter your age :");
            double d = Convert.ToDouble(Console.ReadLine());
           Console.Write(" Enter the name of your country");
            string x = (Console.ReadLine());*/

            Console.Write(" Enter your age: ");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter your country name: ");
            string cn =Console.ReadLine();

            if (age > 40 && cn == "Nigeria" )
            {
                Console.WriteLine(" You are an adult Nigerian");

            }
             if(age > 40 || cn == "Nigeria")
            {
                Console.WriteLine(" You are an adult or a Nigerian");
            }
             if (age < 40 && cn != "Nigeria")
            {
                Console.WriteLine("You are not an adult nor a Nigerian");
            }


        }
    }
}
