using System;

namespace Types_of_array
{
    class Program
    {                     
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Your subject and score");

            int [,] score = [10,2];
            int[][] scores = new int[4][];
            
            string[] student = new string[10];
            int[] totalscore = new int[10]; 

            for (int i = 0; i < score.GetLength(0); i++)
            {
                Console.WriteLine("Enter your name:");
                student[i] = Console.ReadLine();
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter your score:  ");
                    


                }
                
            }


        }
    }
}
