using System;

namespace Question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(" Welcome to Our Quiz Competition");

            Random rmd1 = new Random();
            int random1 = rmd1.Next(1, 7);

            Random rmd2 = new Random();
            int random2 = rmd2.Next(1, 7);

            int product = random1 * random2;

            Console.WriteLine($" What is the multlipication of {random1} * {random2}");
            int anwser = int.Parse(Console.ReadLine());

            if (anwser == product)
            {
                Console.WriteLine("Congratulation");

                bool nextquestion = true;
                while (nextquestion)
                {
                    NextQuestion();
                    Console.WriteLine(" Very Good, Next Question ");

                    Console.WriteLine(" To continue type 'yes' / to stop type 'no'  ");
                    string ans = Console.ReadLine();
                    if (ans == "no" || ans == "No")
                    {
                        break;
                    }
                }
            }

            if (anwser != product)
            {

                Console.WriteLine($" Wrong answer, try again : What is the  {random1} * {random2}");
                int anwse = int.Parse(Console.ReadLine());

                bool nextquestion = true;
                while (nextquestion)
                {
                    Console.WriteLine(" Correct, Next Question  ");
                    NextQuestion();
                    Console.WriteLine(" Very Good, Next Question ");

                    Console.WriteLine(" To continue type 'yes' / to stop type 'no'  ");
                    string ans = Console.ReadLine();
                    if (ans == "no" || ans == "No")
                    {
                        break;
                    }
                }
            }
        }


        public static void NextQuestion()
        {
            Random rmd1 = new Random();
            int random1 = rmd1.Next(1, 7);

            Random rmd2 = new Random();
            int random2 = rmd2.Next(1, 7);
            int total = random1 * random2;

            Console.WriteLine($" {random1} * {random2} ");
            int ans = int.Parse(Console.ReadLine());

            if (ans == total)
            {
                Console.WriteLine(" Correct ");
            }
            return;
        }
    }
}
    

