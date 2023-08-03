using System;

namespace CodeChallenge10122021
{
    class Program
    {
        static void Main(string[] args)
        {
            
     
            Console.WriteLine("Enter an integer value ");
            int integer = int.Parse(Console.ReadLine());

            int x = CountNumber(integer);

            Console.WriteLine(x);
                
            

        }


        static int CountNumber(int number)
        {
            int count = 0;

            while (number != 0)
            {
                
                number = number / 10;
                count++;
            }
               return count;
        }
        
    }
}
