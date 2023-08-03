using System;
using System.Collections.Generic;
using System.IO;
namespace Indexers_Iteration_and_Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {

            //var result = new Result("ade","ola",12);
            //result[2] = 30;
            //Console.WriteLine(result[5]);
            string name = "Olayemi";
            foreach (var letter in name)
            {
                if (!Char.IsLetter(letter))
                {
                    Console.WriteLine(" Error ");
                }


            }
 
        }

    }
    
    public class Result
    {
        private string FirstName { get; set; }
        private string Lastname { get; set; }
        private string FullName { get{ return $"{Lastname} {FirstName}"; } }
        private int[] Score { get; set; }

        public int this[int i]
        {
            get
            {
                if (i > Score.Length)
                {
                    return 0;
                }

                else
                {
                    return Score[i] +=5;
                }
            }

            set
            {
                if (i  < Score.Length && i >= 0)
                {
                    Score[i] = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException("The index given is not valid");
                }
            }         
        
        }
        


        public Result(string firstname, string lastname, int number)
        {
           FirstName = firstname;
           Lastname = lastname;
           Score = new int[5];
        }


    }



}
