using System;

namespace ConsoleApp14
{
    class Program
    {
        public static void Main(string[] args)
        {
            //   1
            //int final = EvenNumber();
            //Console.WriteLine($" the even number is { final } ");




            ////   2
            //int result = PrintOdd();
            //    Console.WriteLine($" the oddnumber is { result } ");


            //     3
            //int total = Maximum();
            //Console.WriteLine($"  the maximum value is {total}");


            //   4

            int final = Minimum();
            Console.WriteLine($" the minimum value is {final}");














           
        }   

         //   1
        public static int EvenNumber()
        {
            Console.WriteLine("Input your value");
            int value = int.Parse(Console.ReadLine());
            int[] even = new int[value];
            int numbers = 0;
            int count = 0;
            
            
            while (numbers < value) 
            {
                Console.WriteLine("enter your digit");
                int digit = int.Parse(Console.ReadLine());

                even[numbers] = digit;
                numbers++;
            }
            foreach (var item in even)
            {
                if (item%2==0)
                {
                    count++;
                }
            }
          
            return count;


        }
                        //   3
        //public static int Maximum()
        //{
        //    Console.WriteLine("Write your Maximum");
        //    int maximum = int.Parse(Console.ReadLine());
        //    int [] value = new int [maximum];
        //    int num = 0;
        //    int num1 = 0;

        //    while (num < maximum)
        //    {
        //        Console.WriteLine("Enter your number");
        //        int max = int.Parse(Console.ReadLine());
        //        value[num]= max;
        //        num++;
        //    }
        //    foreach (var item in value)
        //    {     
        //        if (item >= num1)
        //        {
        //             num1=item;
        //        }
           
        //    }

        //    return num1;
        //}       


                //  4

            public static int Minimum()
            {
                Console.WriteLine("enter amount");
                int amount = int.Parse(Console.ReadLine());
                int[] value = new int[amount];
                int pos = 0;
                while (pos <amount)
                {
                    Console.WriteLine("Enter number");
                    int minimum = int.Parse(Console.ReadLine());
                    value[pos] = minimum;
                    pos++;
                }

               int minimumNumber =value[0];
                foreach (var item in value)
                {
                    if (minimumNumber > item)
                    {
                         minimumNumber = item;
                    }
                }

                return minimumNumber;
            }     
	    

	     



















                 //  2

            public static int PrintOdd()
            {
                Console.WriteLine("Input your array number");
                int arraynumber = int.Parse(Console.ReadLine());
                int[] numbers = new int[arraynumber];
                int position  = 0;
                int count = 0;
                  while (position<arraynumber)
                  {
                    Console.WriteLine("Your number value");
                    int value = int.Parse(Console.ReadLine());

                    numbers[position] = value;
                        position++;
                  }
                   foreach (var item in numbers)
                   {
                
                        if (item%2!=0)
                        {
                            count++;
                        }
                   }

                    return count;



            }
            
                    
                    
                    
             

                
    }
       
}

        

                    







