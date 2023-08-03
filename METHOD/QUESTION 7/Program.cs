using System;

namespace QUESTION_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO PRINT A NUMBER IN REVERSE ORDER");
            Reverse();
        }

          public static void Reverse ()
          {
              Console.WriteLine("enter a number:");
              int num = int.Parse(Console.ReadLine());
              for (;;)
              {
                  int div = num / 10;
                  int mod = num % 10;
                  num = div;
                  int reverse = mod;
                  Console.Write(reverse);
                  if (div==0)
                  {
                      break;
                  }
              }
          }
    }
}
