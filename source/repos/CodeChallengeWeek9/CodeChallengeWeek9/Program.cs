using System;
using System.Collections.Generic;

namespace CodeChallengeWeek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word =
            {
                "a",
                "ab",
                "abc",
                "d",
                "cd",
                "bcd",
                "abcd"

            };
            int see = FindWord(word);
            Console.WriteLine(see);

        }

            public static int FindWord(string[] word)
            {
                List<int> save = new List<int>();
                bool isContain = false;
                int max = 0;
                int multiple = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {

                        isContain = word[i].Contains(word[j]);
                        if (isContain==false && word[i].Length == word[j].Length)
                        {
                          multiple = word[i].Length * word[j].Length;
                            save.Add(multiple);
                       
                        }
                    }

                }


                     foreach (var item in save)
                     {
                        if (item > max)
                        {
                            max = item;
                        }
                        

                     }
                    return max;
            }

        
    }
}
