using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine (" abdullateef ");
            //string myname = Console.ReadLine();
            //Console.WriteLine("abdulateef ");
            //Console.WriteLine("dhjdhdhgh");
            //Console.WriteLine("dfsret ");
            //string Myname = Console.ReadLine();

             PrintEven(2, 3);
           string name = ReverseString("Alarm");
            Console.WriteLine(name);
            //PrintReverse(12);            
        }


        //public static void PrintReverse( int number)
        //{
        //    Console.WriteLine(number);

        //    if (number!=1)
        //    {

        //         PrintReverse(number - 1);
        //    }
        //} 


        public static void PrintEven(int a, int b)
        {
         
            if (a % 2 == 0)
            {
                PrintEven(a + 1, b);

            }

            if (a==b)
            {
                return;
            }
            
        }


        public static string ReverseString(string word)
        {
            if (word.Length == 1)
            {
                return word;
            }

            return word[word.Length - 1] + ReverseString(word.Substring(0,word.Length - 1));

        }


        //public void PrimePrime(int a , int b)
        //{
        //    if (Isprime(a,a-1))
        //    {

        //    }
        //}

        //public bool Isprime(int c, int d)
        //{
        //    if (c == 1)
        //    {
        //        return true;
        //    }

        //    if (d % 2 == 0)
        //    {

        //    }
        //}
        
    }
}
