using System;
using System.Collections.Generic;

namespace CodeChallengeWeek8
{
    class Program
    {
        static void Main(string[] args)
        { 



        }


        public bool CheckPermutation(string s1, string s2)
        {

            s1 = "Banana";
            s2 = "Abaseki";

            if (s1.Length > s2.Length)
            {
                return false;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                    if (s1.Length == s2.Length)
                    {

                        return true;
                    }
            }

            for (int j = s1.Length; j  < s2.Length; j++)
            {
                if (s1.Length == s2.Length)
                {
                    return true;
                }                
            }

            return false;
        }


        //public  List<string> GenerateParenthesis( int n)
        //{
        //    List<string> number = new List<string>();
        //    string left="";
        //    string right="";
        //    if (n == 0)
        //    {
        //        number.Add("");
        //    }
        //    else
        //    {
        //        for (int i = 0; i < n; i++)
        //        {
        //            for (GenerateParenthesis(i))
        //            {
        //                for (GenerateParenthesis(n - 1 - i));
        //                {
        //                    number.Add("(" + left + ")" + right);
        //                }
        //            }
        //        }
        //    }
        //    return number;
        //}
        
    }
}
