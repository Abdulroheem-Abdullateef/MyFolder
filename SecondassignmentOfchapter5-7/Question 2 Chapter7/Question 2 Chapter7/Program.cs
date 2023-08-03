using System;

namespace Question_2_Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int number1 = int.Parse(Console.ReadLine());

            int[] num1 = new int[number1];


            Console.WriteLine("Enter a number2 ");
            int number2 = int.Parse(Console.ReadLine());

            int[] num2 = new int[number2];

            
            for (int i = 0; i < num1.Length; i++)
            {
                num1[i] = number1;

                bool issame = true;
                if (number1!=number2)
                {
                    Console.WriteLine("not equal");
                }

                for (int j = 0; j < num2.Length; j++)
                {
                    num2[j] = number2;

                }

                for (int k = 0; k < num1.Length; k++)
                {
                    if (num1[k]!=num2[i])
                    {
                        issame = false;
                        break;
                    }
                }

                if (issame)
                {
                    Console.WriteLine("We have new array");
                }

            }

            



        }
    }
}
