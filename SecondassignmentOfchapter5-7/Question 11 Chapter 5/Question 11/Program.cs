using System;

namespace Question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 0 to 999 and will be transform to word ");
            int number = int.Parse(Console.ReadLine());

            int hundred = number /100;
            int tens;
            
            if (number > 99)
            {
                Console.WriteLine("And");
                hundred = number % 100;
            }

            else
            {
                tens = (int)(number * 10);
                
            }

              int  unit = number % 10;

            switch (hundred)
            {
                case 1:
                    Console.WriteLine(" One Hundred");
                    break;

                case 2:
                    Console.WriteLine("Two hundred");
                    break;

                case 3:
                    Console.WriteLine("Three hundred");
                    break;

                case 4:
                    Console.WriteLine(" Four hundred");
                    break;

                case 5:
                    Console.WriteLine(" Five hundred");
                    break;

                case 6:
                    Console.WriteLine(" Six hundred");
                    break;


                case 7:
                    Console.WriteLine(" Seven hundred");
                    break;

                case 8:
                    Console.WriteLine(" Eight hundred");
                    break;


                case 9:
                    Console.WriteLine(" Nine hundred");
                    break;

                default:
                    break;
            }






            switch (tens)
            {
                case 1:
                    Console.WriteLine(" Twenty ");
                    break;

                case 2:
                    Console.WriteLine("Thirty ");
                    break;

                case 3:
                    Console.WriteLine("Fourty");
                    break;

                case 4:
                    Console.WriteLine(" Fifty");
                    break;

                case 5:
                    Console.WriteLine(" Sixty");
                    break;

                case 6:
                    Console.WriteLine(" Six hundred");
                    break;


                case 7:
                    Console.WriteLine(" Seven hundred");
                    break;

                case 8:
                    Console.WriteLine(" Eight hundred");
                    break;


                case 9:
                    Console.WriteLine(" Nine hundred");
                    break;

                default:
                    break;
            }










        }
    }
}
