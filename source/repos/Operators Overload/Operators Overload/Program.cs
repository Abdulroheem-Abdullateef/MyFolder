using System;
using System.Collections.Generic;
namespace Operators_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var score = new Score
            {
                Name = "Ade",
                Mark = 34
            };

            var score2 = new Score
            {
                Name = "Olu",
                Mark = 22

            };

            var sum = score + score2;
            Console.WriteLine(sum);

            object  a = 5;
            a = "Bola";
            Score score1 = new Score();
            

        }
        
        class Score
        {
            public string Name { get; set; }
            public int Mark { get; set; }

            //public static int operator +(Score a, Score b)
            //{
            //    return a.Mark + b.Mark; ;
            //}
            
            public static Score operator +(Score a, Score b)
            {
                return new Score
                {
                    Name = a.Name + b.Name,
                    Mark = a.Mark + b.Mark
                };
            }
        
            public static Score operator ++(Score a)
            {
                return Mark = a.Mark += 5;
            }
        }
        

    }
}
