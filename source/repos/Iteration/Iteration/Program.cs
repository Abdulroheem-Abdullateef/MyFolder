using System;
using System.Collections.Generic;

namespace Iteration
{
    class Result
    {
        static void Main(string[] args)
        {
            var result = GetEvenNumbers(20).GetEnumerator();
            while (result.MoveNext())
            {
                Console.WriteLine(result.Current);
            }
        }


        static IEnumerable <int> GetEvenNumbers(int lastnumber)
        {
            for (int i = 0; i <= lastnumber; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                    
                }

            }

        }
    }

   
}
