using System;

namespace Assessment_Tutorial_Assignment_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your name?");
            string name = Console.ReadLine();

            Console.Write("How old are you?");
            string age = Console.ReadLine();


            Console.Write("your gender please?");
            string gender = Console.ReadLine();
            
            Console.Write("Can i have your phone number?");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Hello "+ name +" it's nice to meet you");
            Console.WriteLine("Your age is "+ age +" you are a " + gender);
            Console.WriteLine("and your phonenumber is "+ phonenumber);






            Console.WriteLine("Amount to paid");
            double borrowed = Convert.ToDouble(Console.ReadLine());

            double interest = 0.08 * borrowed;
            double amount = interest + borrowed;

            Console.WriteLine(amount);
            
        }
    }
}
