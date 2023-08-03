using System;

namespace CsharpDay1Class
{
    class Program
    {
        static void Main(string[] args)
        {


            //int count = 0;
            //int max = 0;
            //int number;
            //do
            //{
            //    Console.WriteLine("Enter number");
            //    number = int.Parse(Console.ReadLine());
            //    if (number == max)
            //    {
            //        count++;
            //    }
            //    else if (number > max)
            //    {
            //        max = number;
            //        count = 1;
            //    }

            //} while (number != 0);
            //Console.WriteLine($"The max number is {max} and the count is {count} ");




            {
                /*Console.WriteLine("Enter your integer number");
                int num= int.Parse(Console.ReadLine());
                int k = 10;
                double no = k / 5;
                double no1 = k / 6;

                double no2 = k % 10;*/


                //class work
                //    // 1
                //    Console.WriteLine("Celsius degree");
                //    double celsius = double.Parse(Console.ReadLine());
                //    double fahreheit = (9 / 5) * celsius + 32;

                //    Console.WriteLine(fahreheit);

                //    // 2

                //    Console.WriteLine("Radius");
                //    double radius = double.Parse(Console.ReadLine());

                //    Console.WriteLine("Length");
                //    double length = double.Parse(Console.ReadLine());

                //    Console.WriteLine("Area");
                //    double area = double.Parse(Console.ReadLine());

                //    double A = 22 / 7 * radius * radius;
                //    double V = area * length;

                //    Console.WriteLine(A + V);

                //    //3
                //    Console.WriteLine("Number in feet");
                //    double feet = double.Parse(Console.ReadLine());
                //    double meter = feet * 0.305;

                //    Console.WriteLine($" One foot is + {meter} meter");

                //    //4
                //    Console.WriteLine("Pounds");
                //    double kilogram = double.Parse(Console.ReadLine());
                //    double pounds = kilogram * 0.454;

                //    Console.WriteLine($" One pounds is {pounds} kilogram");

                //    //5

                //    Console.WriteLine("Subtotal");
                //    double subtotal = double.Parse(Console.ReadLine());

                //    Console.WriteLine("gratuityrate");
                //    double gratuityrate = double.Parse(Console.ReadLine());






                //    //6

                //    Console.WriteLine("integer number");
                //    double integer = double.Parse(Console.ReadLine());




                //    // 7
                //    Console.WriteLine("Enter minutes");
                //    double minutes = double.Parse(Console.ReadLine());

                //    double years = 1 * 365;
                //    double days = 1 * 24;

                //    Console.WriteLine($" the number of {years} and {days} ");

                //    //8
                //    Console.WriteLine("Start velocity in meter/seconds");
                //    double startvelocity = double.Parse(Console.ReadLine());
                //    Console.WriteLine("Ending velocity in meter/second");
                //    double endingvelocity = double.Parse(Console.ReadLine());
                //    Console.WriteLine("Time Spent in seconds");
                //    double timespent = double.Parse(Console.ReadLine());

                //    double average = startvelocity / timespent;


                //    Console.WriteLine(average);

                //    //9
                //    Console.WriteLine("Amount of water in kilograms");
                //    double water = double.Parse(Console.ReadLine());

                //    Console.WriteLine("Initial of water in kilograms");
                //    double initial = double.Parse(Console.ReadLine());


                //    Console.WriteLine("Final");
                //    double final = double.Parse(Console.ReadLine());

                //    double Energy = water * (final - initial) * 4184;

                //    //10
                //    Console.WriteLine("Monthly Amount");
                //    double monthly = double.Parse(Console.ReadLine());
                //    double firstmonth = 100 * (1 + 0.00417);
                //    double secondmonth = firstmonth * (1 + 0.00417);
                //    double thirdmonth = secondmonth + monthly;







                //    // assignmet day1

                //    //  1

                //    Console.WriteLine(" future Day");
                //    int day = int.Parse(Console.ReadLine());



                //    switch (day)
                //    {
                //        case 1:
                //            Console.WriteLine("Monday");
                //            break;

                //        case 2:
                //            Console.WriteLine("Tuesday");
                //            break;

                //        case 3:
                //            Console.WriteLine("wednesday");
                //            break;

                //        case 4:
                //            Console.WriteLine("Thursday");
                //            break;

                //        case 5:
                //            Console.WriteLine("Friday");
                //            break;

                //        case 6:
                //            Console.WriteLine("Saturday");
                //            break;


                //        case 7:
                //            Console.WriteLine("Sunday");
                //            break;
                //    }
                //}





                //// 7

                //Console.WriteLine("Enter minutes");
                //double minutes = double.Parse(Console.ReadLine());

                //double years = 1 * 365;
                //double days = 60 / 24;

                //Console.WriteLine($" the number of {years} and {days} ");


                //// 2 
                ///
                //Console.WriteLine("Three Num");
                //int num = int.Parse(Console.ReadLine());

                //Console.WriteLine("Three Num");
                //int num2 = int.Parse(Console.ReadLine());

                //Console.WriteLine("Three Num");
                //int num3 = int.Parse(Console.ReadLine());

                //int total = num = num2 = num3;
                //Console.WriteLine(total);


                //5

                Console.WriteLine("Enter a amount");
                double amount = double.Parse(Console.ReadLine());
                double saving = 0;
                for (int i = 0; i < 6; i++)
                {
                    saving = amount + saving * (1 + 0.0417);
                }
                Console.WriteLine(saving);

                // 6
                Console.WriteLine("Triangle");

                Console.WriteLine("Edges 1");
                int Edges1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Edges 2");
                int Edges2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Edges 3");
                int Edges3 = int.Parse(Console.ReadLine());

                int perimeter = Edges1 + Edges2 + Edges3;

                int sum1 = Edges1 + Edges2;
                int sum2 = Edges2 + Edges3;
                int sum3 = Edges3 + Edges2;
                if (sum1>Edges3)
                {
                    Console.WriteLine("The input is valid");
                }
                 
                

}   }   }   }










   

