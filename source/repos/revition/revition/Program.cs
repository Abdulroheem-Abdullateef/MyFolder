using System;

namespace revition
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int name = 14;
            //int type = 12;
            //int[] number = { 1, 4, 5  };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum +=  number[i];
            //}
            //int total = sum / 3;
            //Console.WriteLine($" {name + type} ");

            //int sum1 = 3 + 4;
            //int sum2 = 3 + 5;
            //int sum3 = 4 + 5;
            //if(sum1 > 5 && sum2 >4 && sum3 > 3)
            //{
            //    Console.WriteLine(3 + 4 + 5);
            //}
            //else
            //{
            //    Console.WriteLine("Your input is invalid");
            //}
            //double kilogram = 1;

            //while (kilogram < 200)
            //{
            //    double pounds = kilogram * 2.205;
            //    Console.WriteLine($" {kilogram}    {pounds}");
            //    kilogram += 2;

            //}

            //     int max = 0;
            //     int count = 0;
            //     int endOfInput = 1;
            //     Console.WriteLine("Enter a value : ");
            //     int value = int.Parse(Console.ReadLine());
            //while () ;
            //    {
            //         Console.WriteLine("Enter a value : ");
            //         int f = int.Parse(Console.ReadLine());

            //         if (value > max && value != 0)
            //         {
            //                  max = value;
            //                 count++;
            //         }

            //         else
            //         {
            //             break;
            //         }
            //         endOfInput++;
            //    }
            //     Console.WriteLine($"maximim number is {max} and occurence is {count}");





            int odd = 0;
            int even = 0;
            Console.WriteLine("Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            int count = number;
            while (number>even&&number%2==0)
            {
                even = number;
                odd++;


                if (number > odd && number != 0)
                {
                    odd = number;
                    even++;
                }




       

            }





        }
    }
}
