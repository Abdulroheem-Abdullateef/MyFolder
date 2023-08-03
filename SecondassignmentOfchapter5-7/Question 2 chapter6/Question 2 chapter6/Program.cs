using System;

namespace Question_2_chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                if (i % 3 != 0)
                {
                    if (i % 7 !=0)
                    {
                        Console.WriteLine(i);
                    }
                    
                    
               
                }

                
            
            }

        }
    }
}
