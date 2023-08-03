using System;

namespace QUESTION_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to print name");
            Console.WriteLine("enter your name:");
            string name =Console.ReadLine();
            string x = PrintName(name);

                Console.WriteLine($"Hello {x}");
        }
        
   
    
          
        public static string PrintName(string name)
        {
            return name;
        }
    }
}
