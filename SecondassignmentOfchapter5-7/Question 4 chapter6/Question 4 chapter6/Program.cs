using System;

namespace Question_4_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Club");
                        break;
                    case 2:
                        Console.WriteLine("Diamond");
                        break;
                    case 3:
                        Console.WriteLine("Heart");
                        break;
                    case 4:
                        Console.WriteLine("Spades");
                        break;
                    default:
                        break;

                }


                for (int j = 2; j <= 14; j++)
                {
                    switch (j)
                    {
                        case 2:
                            Console.WriteLine("2");
                            break;

                        case 3:
                            Console.WriteLine("3");
                            break;

                        case 4:
                            Console.WriteLine("4");
                            break;

                        case 5:
                            Console.WriteLine("5");
                            break;

                        case 6:
                            Console.WriteLine("6");
                            break;

                        case 7:
                            Console.WriteLine("7");
                            break;

                        case 8:
                            Console.WriteLine("8");
                            break;

                        case 9:
                            Console.WriteLine("9");
                            break;
                        case 10:
                            Console.WriteLine("10");
                            break;

                        case 11:
                            Console.WriteLine("J");
                            break;

                        case 12:
                            Console.WriteLine("Q");
                            break;

                        case 13:
                            Console.WriteLine("K");
                            break;

                        case 14:
                            Console.WriteLine("A");
                            break; 


                        default:
                        
                            Console.WriteLine("Invalid input");
                            break;

                           
                    }

                  
                }
                Console.WriteLine();
            }

        }
    }
}
