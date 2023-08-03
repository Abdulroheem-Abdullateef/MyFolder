using System;

namespace Assesstment_assignment_Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ? ");
            string name = Console.ReadLine();

            Console.Write("How old are you ? ");
            string age = Console.ReadLine();

            Console.Write("your gender please  ? ");
            string gender = Console.ReadLine();


            Console.Write("Can i have your phone number ? ");
            string phonenumber = Console.ReadLine();



            Console.WriteLine("Hello "  + name + ", it's nice to meet you");
            Console.WriteLine("Your age is " + age + ", you are a " + gender);
            Console.WriteLine("and your phonenumber is " + phonenumber);




            long P = 10;
            long R = 21;
            long T = 30;
            long I = P * R * T / 100;


            Console.WriteLine(I);


            double Z = 0.5;
            double H = 2;
            double A = 13;
            double B = 14;
            double O = Z*(A+B)*H;


            Console.WriteLine(O);




            int celsius = 73;
            int kelvin = 273 + celsius;

            Console.WriteLine(kelvin);

            








        }
    }
}
