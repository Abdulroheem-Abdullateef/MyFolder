using System;

namespace Abdullateef
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter first number");
    //        int number1 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Enter second number");
    //        int number2 = int.Parse(Console.ReadLine());

    //        int sum = SumOfNumber(number1,number2);

    //        Console.WriteLine("$The addtion of {number1} + {number2] = {sum}");

    //    }


    //    static int SumOfNumber(int a , int b)
    //    {
            
    //        return a + b;
    //    }
    //}
}



class HelloCSharp
{
    static void Main()
    {
        for (int i = 2; i < 103; i++)
        {
            if (i % 2 == 0) Console.WriteLine(i);
            else Console.Write("-{0}", i);
        }
    }
}


//class Practice
//{


//        //static void Main(string[] args)
//        //{
//        //    int i = 1;
//        //    Console.WriteLine("Previous value of integer i:" + i.ToString());
//        //    string test = GetNextName(ref i);
//        //    Console.WriteLine("Current value of integer i:" + i.ToString());
//        //}


//        //public static string GetNextName(ref int id)
//        //{
//        //    string returnText = "Next-" + id.ToString();
//        //    id += 1;
//        //    return returnText;
//        //}
//}



