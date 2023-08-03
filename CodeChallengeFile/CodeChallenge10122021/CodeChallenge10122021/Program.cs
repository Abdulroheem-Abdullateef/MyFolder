using System;

namespace CodeChallenge10122021
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer value ");
            string integer =  Console.ReadLine();
            int num = int.Parse(integer);
            int count = 0;
            
            
            foreach (var item in integer)
            {
                if (item != 0 && item % item  == 0 )
                {
                    count++;
                }
                Console.WriteLine(count);
            }










            //Console.WriteLine("Enter an integer value ");
            //int integer = int.Parse(Console.ReadLine());

            //int x = FindDigits(integer);

            //Console.WriteLine(x);



        }


        static int FindDigits(int n)
            {

                int divisor = 0;

                int orgNumber = n;

                while (n > 0)
                {
                    int digit = n % 10;
            
                    n = n / 10;
                    
                    if (digit == 0)
                    {
                        continue;

                    }
            
                    else if (orgNumber % digit == 0)
                    {
                        divisor++;
                    }
                }
                 
                 return divisor;
            }

    }
}
