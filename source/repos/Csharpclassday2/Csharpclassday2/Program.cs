using System;
using System.Collections.Generic;

namespace Csharpclassday2
{
    class Program
    {
        static void Main(string[] args)
        {
            //// list 
            List<int> number = new List<int>() {1,2};
            number.Add(0);

            int sum = 0;
            foreach (int item in number)
            {
                sum += item;
            }
            Console.WriteLine(sum);





            //List<int> total = new List<int>() { 1,3,2};
            //int odd = 0;
            //int even = 0;
            //foreach (var item in total)
            //{          

            //    if (item%2==0)
            //    {
            //        even++;
            //    }

            //    else if (item%2!=0)  
            //    {
            //        odd++;
            //    }

            //}

            //Console.WriteLine($" the occurs value of odd is {odd} and the even number is {even}");



            //Dictionary<string, int> studentsMarks = new Dictionary<string, int>();
            //studentsMarks["ola"] = 20;
            //studentsMarks["wale"] = 10;
            //var keys = studentsMarks.Keys;
            //foreach (var key in keys)
            //{
            //    Console.WriteLine(key);

            //int[] total = new int[6] { 1, 4, 6, 7, 5, 3 };
            //int sum = 0;

            //foreach (int item in total)
            //{
            //    sum += item;
            //    Console.WriteLine(sum);
            //}


            //int[] value = new int[5] { 2, 4, 6, 8, 10 };
            //int s = 0;
            //foreach (var item in value)
            //{
            //    Console.WriteLine(item);
            //}

            //int [] number = new int [6] {1,-4,3,-5,6,-1};
            //int n = 0;
            //foreach (var item in number)
            //{
            //    if (item<0)
            //    {

            //        Console.WriteLine(item);
            //    }
            //}


            //int[] array = new int[] { 1, -2, 3, -4, 5, -6 };
            //int negative = 0;
            //int positive = 0;
            //foreach (var item in array)
            //{
            //    if (item < 0)
            //    {
            //        negative++;

            //    }
            //    else if (item > 0)
            //    {
            //        positive++;
            //    }

            //}
            //Console.WriteLine($" the occurs of positive is {positive} and the negative occurs {negative}");




            /*Dictionary<string, int> agename = new Dictionary<string, int>();
            agename["ola"] = 20;
            agename["wale"] = 50;
            agename["Dele"] = 30;
            agename["john"] = 10;
            agename["Ade"] = 60;

            var name = agename.Keys;
            foreach (var item in agename)
            {
                Console.WriteLine($" name: {item} , age: {item}");

            }*/

            // classwork 1
            //int[] element = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int sum = 0; 
            //foreach (int item in element)
            //{
            //    Console.WriteLine(item);
            //}

            //2
            //int[] value = new int[6] { 1, -2, 3, -4, 5, -6 };

            //foreach (int item in value)
            //{
            //    if (item < 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //3
            //int[] negative = new int[6] { 1, -2, 3, -4, 5, -6 };

            //foreach (int item in value)
            //{
            //    if (item > 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //int[] numbers = new int[6] { 1, -2, 3, -4, 5, -6 };
            //int positive = 0;
            //int negative = 0;
            //foreach (int number in numbers)
            //{
            //    if (number < 0)
            //    {
            //        negative++;
            //    }
            //    else if (number > 0)
            //    {
            //        positive++;
            //    }
            //}
            //Console.WriteLine($"The positive value {positive} occurs while negative value {negative} ");


            // 4

            //int[] value = new int[6] { 1, -2, 3, -4, 5, -6 };
            //int max = 0;
            //int minimum = 0;
            //foreach (int item in value)
            //{
            //    if (item > 0)
            //    {
            //        max = item;
            //    }
            //    else if (item < 0)
            //    {
            //        minimum=item;
            //    }
            //}
            //Console.WriteLine($"The minimum value {minimum} and the maximum value {max} ");


            // 5




            //Console.WriteLine("Enter your value unknow");
            //int unknow = int.Parse(Console.ReadLine());
            //int[] know = new int[unknow];
            //int numberofodds = 0;
            //int numberofevens = 0;

            //for (int i = 0; i <unknow; i++)
            //{
            //    Console.WriteLine("Enter element ");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x % 2 == 0)
            //    {
            //        numberofevens++;


            //    }
            //    else
            //    {
            //        numberofodds++;
            //    }

            //}
            //Console.WriteLine($" {numberofodds}   {numberofevens}");



            //int[] x = new int[5] { 1, 2, 4, 5, 6 };
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}






            //// book of how to programming
            //int[] y = new int[6] { 1, -2, 3, -4, 5, -6 };
            //foreach (int item in y)
            //{
            //    if (item < 0) 
            //    {
            //        //Console.WriteLine($"\"{item}\"");
            //        //Console.WriteLine("\t \"item\" \n \r");
            //        Console.WriteLine($" \r {item}");
            //    }
            //}


        }


        //int[] sum = new int[] { 1, -2, 3, 4, 5, 6 - 7 };
        //int y = 0;
        //foreach (int sums in sum)
        //{
        //    Console.WriteLine(sums);
        //}

        //int[] max = new int[]  {1, -2, 3, -4, 5, -6};
        //int z = 0;
        //foreach (int mini in max)
        //{
        //    mini <=;
        //    //}








        // namespace ConsoleApp14
        //{
        //    class Program
        //    {
        //        static void Main(string[] args)
        //        {
        //            Console.WriteLine("Enter your integer");
        //            int integer = int.Parse(Console.ReadLine());
        //            int[] unknow = new int[integer];
        //            if (integer < 0) ;
        //            {

        //            }
        //            foreach (var item in unknow)
        //            {
        //                Console.WriteLine(integer);
        //                integer++;
        //            }



        //            string firstname = ("Abdulroheem");
        //            string lastname = ("Abdullateef");
        //            int age = 22;

        //            public static void Printinfo(string firstname, string lastname, string name);
        //            Console.WriteLine($"Your name is {firs} ")







        //Console.WriteLine("Enter your Lastname");
        //

        //Console.WriteLine("Enter your age ");
        //int age = int.Parse(Console.ReadLine());


        //Console.WriteLine("Enter your Firstname ");



        //    }

        //    public static void PrintInfo()
        //    {
        //        Console.WriteLine("What is your name");
        //        string firstname =Console.ReadLine();
        //        Console.WriteLine($"Your firstname is{firstname} ");

        //        Console.WriteLine("What is lastname");
        //        string lastname = Console.ReadLine();
        //        Console.WriteLine($"Your lastname is {lastname} ");

        //        Console.WriteLine("Your age ");
        //        int age = int.Parse(Console.ReadLine());
        //        Console.WriteLine($"Your age is{age} ");
        //    Console.WriteLine("What is your name");
        //string firstname =Console.ReadLine();
        //Console.WriteLine($"Your firstname is{firstname} ");

        //Console.WriteLine("What is lastname");
        //string lastname = Console.ReadLine();
        //Console.WriteLine($"Your lastname is {lastname} ");

        //Console.WriteLine("Your age ");
        //int age = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Your age is{age} ");
        //return(firstname, lastname, age);



        //public static int CheckHighest(int a, int b, int c)
        //{

        //int max = CheckHighest(89, 1000, 100);
        //Console.WriteLine($"The max number is {max}");


        //    int max = a;
        //    if(max < b)
        //    {
        //        max = b;
        //    }
        //    else if(max < c)
        //    {
        //        max = c;
        //    }
        //    return max;  //By Bro Abdulrasak.




        //for (int i = 0; i < even; i++)
        //{
        //    Console.WriteLine("Count evennumber total");
        //    int total = int.Parse(Console.ReadLine());
        //    if (total % 2 == 0)
        //    {
        //        evennumber++;
        //    }

        //}

        //return evennumber;


        //public static int Printarray(int[] numbers)
        //{
        //    int value = 0;
        //    foreach (var item in numbers)
        //    {
        //        value += item;
        //    }
        //    int result = value/2;
        //    return result;
        //}

        //public static double array(int[] numbers)
        //{
        //    double value =0;
        //    foreach (var item in numbers)
        //    {
        //        value += item;
        //    }
        //    double result = Math.Sqrt(value);
        //    return result;
        //}













    }
}    
			
            

                
       


        






          














