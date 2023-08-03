using System;

namespace QUESTION_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAM TO MULTIPLY POLYNOMIAL OF THREE COEFFICIENTS");
            multiplypolynomial();
        }
        public static void multiplypolynomial()
        {
             Console.WriteLine("Enter the co-efficient of x^0");
             int num1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the co-efficient of x^1");
             int num2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the co-efficient of x^2");
             int num3 = int.Parse(Console.ReadLine());

             int [] array = {num1,num2,num2};
             int [] array2 = {num1, num2};    
             int input1 = 0;   
             int input2 = 0; 
             int input3 = 0; 
             int input4 = 0; 
             int input5 = 0; 
             int input6 = 0; 
             int x= 0;
             for (int i = 0; i<array2.Length; i++)
             {
                if (i == 0)
                {
                    input1 = array[x]*array2[0];
                    input2 = array[x]*array2[1];
                }
                else if (i ==1)
                {
                    input3 = array[x]*array2[0];
                    input4 = array[x]*array2[1];
                }
                 else if (i ==2)
                {
                    input5 = array[x]*array2[0];
                    input6 = array[x]*array2[1];
                }
                x++;
             }
             int a = input2 + input3;
             int b = input4 + input5;
             Console.WriteLine($"The result of the factorial is {input1}x^3 + {a}x^2 + {b}x^1 + {input6}x^0 ");

                   

             
        }
    }
}
