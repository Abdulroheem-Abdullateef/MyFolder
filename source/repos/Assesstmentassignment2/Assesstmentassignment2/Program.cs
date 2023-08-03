using System;

namespace Assesstmentassignment2
{
    class Program
    {
        static void Main(string[] args)
        {   //1
            Console.WriteLine("What is the Value of celcius");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double fahreinheit = 0.8+celcius + 32;
            double kelvin = celcius * fahreinheit;

            Console.WriteLine("Amount in fahreiheint is " + fahreinheit);
            Console.WriteLine("Amout in Kelvin" + kelvin );


            //2 

            Console.WriteLine("amont borrowered");
            double interest = Convert.ToDouble(Console.ReadLine());

            double R = 0.08 + interest / 100;

            Console.WriteLine("Amount Borrowed " + R);

            //3a

            if()


        }
    }
}
