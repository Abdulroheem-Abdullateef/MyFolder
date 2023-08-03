using System;

namespace Question_3_chapter_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
               char[] array1 = new char [4] {'w', 'q','m','r' };
               char[] array2 = new char[5] { 'a', 'e', 'w','q','r'};

            if (array1.Length > array2.Length)
            {
                Console.WriteLine("Second is greater than first");
            }


            if (array1.Length < array2.Length)
            {
                Console.WriteLine("First is greater than second");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("First is lexicographically to first");
                    check = false;
                    break;
                }

                if (array1[i]>array2[i])
                {
                    Console.WriteLine("Second is lexicographically to first");
                    check = false;
                    break;
                }

                if (check)
                {
                    Console.WriteLine("The is lexicographically is equal");
                }
            }

        }
    }
}
