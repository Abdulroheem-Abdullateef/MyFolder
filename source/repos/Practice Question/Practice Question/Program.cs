using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


namespace Practice_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Writer = ("A man has a leg");
            //byte[] transfer = Encoding.UTF8.GetBytes(Writer);
            //MemoryStream memoryStream = new MemoryStream(transfer);
            //StreamReader stringReader = new StreamReader(memoryStream);
            //Console.WriteLine(stringReader.ReadToEnd());

            //List<string> names = new List<string>() 
            //{
            //    "Ola","Tunde","Olu","Olumide","Ade","Sola","Wale" 
            //};

            //var names1 = from name in names where name.StartsWith('O') select name;

            //foreach (var item in names1)
            //{
            //    Console.WriteLine(item);

            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,1,2,3,4,5,5,6,6,7,8,9,10,11,12,13
            //};




            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            Dictionary<int, string> keys = new Dictionary<int, string>()
            {
                {2, "ade" },
                {3, "ola" },
                {4,"Wura" },
            };

            foreach (var item in keys)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }



            //    int n = int.Parse(Console.ReadLine());

            //    int[] arrays = new int [n] ;

            //    for (int i = 0; i < arrays.Length; i++)
            //    {
            //        arrays[i] = int.Parse(Console.ReadLine());

            //    }

            //    Console.WriteLine(SimpleArraySum(arrays));

            //}

            //static int SimpleArraySum(int[] array)
            //{
            //    int sum = 0;

            //    foreach (var item in array)
            //    {

            //        sum += item;
            //    }

            //    return sum;




            //int n = int.Parse(Console.ReadLine());

            //int[] arrays = {n};


            //Console.WriteLine(SumOfArray(arrays));

            //static int SumOfArray(int [] num)
            //{
            //    int sum = 0;



            //    foreach (var item in num)
            //    {
            //        sum += item;
            //    }
            //    return sum;
            //}


            //Console.WriteLine("Enter a num:");
            //int a = int.Parse(Console.ReadLine());

            //int s = a % 10;
            //int d = s % 10;
            //int e = a+ d;

            //Console.WriteLine(e);

        }
    }
}
