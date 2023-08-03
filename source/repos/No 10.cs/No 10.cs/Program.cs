using System;

namespace No_10.cs
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int count = 0;
            int max = 0;
            int i =1;

            Console.WriteLine("Enter your number : ");
           int  value = int.Parse(Console.ReadLine());

            
                while(i != 0)
                {
                    Console.WriteLine("Enter your number : ");
                     value = int.Parse(Console.ReadLine());
              
                     if(value > max)
                     {
                        max = value;
                        count++;
                     }
                    i++;
                }
            
            Console.WriteLine($"The maximum num is {max} and it's occurence is {count}");
                

            
        }
    }
}
