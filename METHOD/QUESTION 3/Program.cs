using System;

namespace QUESTION_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO PRINT THE ENGLISH NAME OF THE LAST DIGIT");
            Console.WriteLine("enter your number");
            int x = int.Parse(Console.ReadLine());
            int b = CheckNumber(x);
              


        }
            public static int CheckNumber(int a)
            {
                int num = a % 10;
                switch (num)
                {
                    case 1:
                    Console.WriteLine("Ome");
                    break;
                    case 2:
                    Console.WriteLine("Two");
                    break;
                    case 3:
                    Console.WriteLine("Three");
                    break;
                    case 4:
                    Console.WriteLine("Four");
                    break;
                    case 5:
                    Console.WriteLine("Five");
                    break;
                    case 6:
                    Console.WriteLine("Six");
                    break;
                    case 7:
                    Console.WriteLine("Seven");
                    break;
                    case 8:
                    Console.WriteLine("Eight");
                    break;
                    case 9:
                    Console.WriteLine("Nine");
                    break;
                    default:
                    Console.WriteLine("Zero");
                    break;
                }
            return num;

            }

            
    }
}
