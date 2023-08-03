 using System;

namespace General_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            

           
            string input =Console.ReadLine();
            int result = 0;
            bool check = int.TryParse(input,out result);
            Console.WriteLine($" Result is {result}");
            Console.WriteLine($"Check is {check}");

            

           
        }
    }
}
