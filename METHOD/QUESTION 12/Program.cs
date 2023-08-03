using System;

namespace QUESTION_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO SOLVE POLYNOMIAL EQUATION");
            polynomialSum();
        }
         public static void polynomialSum()
         {
             Console.WriteLine("Enter the co-efficient of x^0");
             int num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the co-efficient of x^1");
             int num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the co-efficient of x^2");
             int num3 = int.Parse(Console.ReadLine());

             int [] numbers1 = {num1, num2, num3};
             int [] numbers2 = {-1, num2};
             int input1 = 0;
             int input2 = 0;
             int x=0;
             for (int i = 0; i<numbers2.Length; i++ )
             {
                 if (i == 0)
                 {
                     input1 = numbers1[x] + numbers2[0];
                 }
                 else
                 {
                     input2 = numbers1[x] + numbers2[1];
                 }
                 x++;
             }
              Console.WriteLine($"The result of the factorial is {num3}x^2  +  {input2}x^1  +  {input1}x^0 ");
         }


    }

}
