using System;

namespace Number_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your edge1");
            int edge1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your edge2");
            int edge2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your edge3");
            int edge3 = int.Parse(Console.ReadLine());

            int perimeter = edge1 + edge2 + edge3;

         

            if (edge1+edge2>edge3&&edge2+edge3>edge1&&edge3+edge1>edge2)
            {

                Console.WriteLine($"your perimeter is {perimeter}");
                
            }

            else 
            {
                Console.WriteLine("your input is invalid");

            }



        }

    }
}
