using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter your number");
            int number1 = int.Parse(Console.ReadLine());



            Console.WriteLine("Enter your number");
            int number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter your number");
            int number3 = int.Parse(Console.ReadLine());



            
            
                if (number1 < number3)
                {
                    number1 = number1 + number3;
                    number3 = number1 - number3;
                    number1 = number1 - number3;

                    Console.WriteLine($" The number in ascending is {number1} , {number2} , {number3} ");
                }
                    if (number2 < number3)
                    {
                        number2 = number2 + number3;
                        number3 = number2 - number3;
                        number2 = number2 - number3;
                     
                        Console.WriteLine($" The number in ascending is {number1} , {number2} , {number3} ");  
                    }

                    if (number1 < number2)
                    {
                        number1 = number1 + number2;
                        number2 = number1 - number2;
                        number1 = number1 - number2;

                        Console.WriteLine($" The number in ascending is {number1} , {number2} , {number3} ");
                    }


            //else
            //{
            //    Console.WriteLine($" The number {number1} , {number2} , {number3} is invalid ");
            //}
                

               

            
                
                

        }

            
        
    }
}
