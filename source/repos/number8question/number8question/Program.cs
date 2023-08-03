using System;
using System.Collections.Generic;

namespace number8question
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = string.Empty;

            int[] array = new int[5];
            int count = 0;
            bool unique = true;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
               
                foreach (var item in array)
                {
                    if (item==number)
                    {
                        unique = false;
                        break;
                    }
                    
                }

                if (number <= 100 && number >= 10 && unique == true)
                {
                    array[count] = number;
                    count++;
                }

            }
           
                for (int j = 0; j < count; j++)
                {
                    n = $"{array[j]},";
                    Console.Write(n);
                }
                    


        }
    }
    
}
