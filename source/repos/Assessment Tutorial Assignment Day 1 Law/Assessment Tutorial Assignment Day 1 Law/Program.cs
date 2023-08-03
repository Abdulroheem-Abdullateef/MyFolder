using System;

namespace Assessment_Tutorial_Assignment_Day_1_Law
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Pls can I have your name ? :");
            string name = Console.ReadLine();
            Console.Write(" What's your age ? : ");
            string age = Console.ReadLine();
            Console.Write(" Are you a male or female ? :");
            string gender = Console.ReadLine();
            Console.Write(" Can I have your digits ? : ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine(" Hello " + name + ", it's nice to meet you . ");
            Console.WriteLine(" Your age is " + age + ", you are a " + gender );
            Console.WriteLine(" and your phone number is " + phoneNumber + ". ");



            double P = 76541.0;
            double R = 45.0;
            double T = 60.0;
            double I = (P * R * T) / 100;
            Console.WriteLine(I);






            double Y = 0.5;
            double A = 40.5;
            double B = 20.5;
            double H = 10.0;
            double V = Y * (A + B) * H;
            Console.WriteLine(V);



            int Celsius = 32;
            int Kelvin = 273 + Celsius;
            Console.WriteLine(Kelvin);












            Console.ReadLine();
        }
    }
}
