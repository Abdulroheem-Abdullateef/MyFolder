using System;

namespace QUESTION_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS 1 TO CHECK FOR REVERSE, 2 TO CHECK FOR AVERAGE OF A SET OF NUMBERS,3 FOR SOLVING LINEAR EQUATION");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Reverse();
            }
            else if (response == 2)
            {
                Average();
            }
            else if (response == 3)
            {
                LinearEquation();
            }
        }

        public static void LinearEquation()
        {
             Console.WriteLine("enter the first number, a :");
             int a = int.Parse(Console.ReadLine());
             Console.WriteLine("enter the second number, b :");
             int b = int.Parse(Console.ReadLine());

             int x = -b / a;
             Console.WriteLine($" The result of linear equation for {b} {a} is {x}");
             

        }

           public static void Average()
           {
                Console.WriteLine("enter the numbers of input you intend to slot in :");
                int num = int.Parse(Console.ReadLine());
                int [] array = new int [num];
                int sum = 0;
                for(int i =0; i<array.Length; i++)
                {
                     Console.WriteLine($"enter the number ");
                     int number = int.Parse(Console.ReadLine());
                     array[i]=number;
                     sum = sum + array[i];

                }
                double average = sum / array.Length;
                Console.WriteLine($" The result of the numbers entered is {average}:");
             
           }

          public static void Reverse()
          {
               Console.WriteLine("enter the number you want to reverse:");
               int num = int.Parse(Console.ReadLine());
               for(;;)
               {
                   int div = num / 10;
                   int mod = num % 10;
                   num = div;
                   int reverse = mod;
                    Console.Write(reverse);
                    if (div == 0)
                    {
                        break;
                    }
               }
          }         

        
    }
}
