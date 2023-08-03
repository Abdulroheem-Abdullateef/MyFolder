using System;

namespace Question_4_Charpter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 1, value = 1, number = 1;

            Console.WriteLine("Enter score");
            int score = int.Parse(Console.ReadLine());

            int[] array = new int[score];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = score;


            }

            for (int i = 0; i < array.Length; i++)
            {
                    if (array[i] == array[i + 1]) 
                    {
                       count++;
                    }


                else  
                {
                    value = 1;
                }

                if (count>value)
                {
                    count = value;
                    number = array[i];

                }
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(number);
            }

        }
    }
}
