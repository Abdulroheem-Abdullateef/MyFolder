using System;
using System.Numerics;

namespace QUESTION_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO FIND THE FACTORIAL OF A NUMBER WITHIN THE RANGE OF 1....100");
            Console.WriteLine("enter the number");
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of {number} is {factorialnumber(number)}");
            Console.WriteLine("THANKS FOR CHECKING YOUR FACTORIAL WITH OUR APP");
            

        }
            public static BigInteger factorialnumber(BigInteger a)
            {
               BigInteger factorial = 1;
                if (a>0 && a<=100)                
                {                    
                    for (BigInteger i =1; i<=a; i++)
                    {
                        factorial = factorial*i;
                    }
                    
                }
                else
                {
                     Console.WriteLine("The factorial you are trying to check is out of range");
                }
                return factorial;
            }
    }
}
