using System;

namespace theprogrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [5];
            int[] num= new int[3];
            int[] numRetry1 = new int[3];
            for (int k = 0; k < 3; k++)

            {
                Random rdm = new Random();
                numbers[k] = rdm.Next(0, 6);
                Console.WriteLine(numbers[k]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Whats ur colour: ");
                int elements = int.Parse(Console.ReadLine());
                num[i] = elements;

                if(Co(numbers, num) == 1)
                {
                    Console.WriteLine("gghhh");
                }

               else if (Co(numbers, num) == 2)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.WriteLine("Whats ur colour: ");
                        int figures = int.Parse(Console.ReadLine());
                        numRetry1[y] = figures;
                        if (Ca(numbers,numRetry1) == 1)
                        {
                            Console.WriteLine("gghhh");
                        }

                       

                    }
                    
                }
            }

        }

        static int Co(int [] numbers, int [] num)
        {
            int j = 0;
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] == num[i])
                {
                    count++;
                }
            }
            if (count == 3)
            {
                j = 1;
            }
            
            else if(count == 2)
            {
                j = 2;
            }
            return j;
        }

        static int Ca(int [] numbers, int [] numRetry1)
        {
            int count = 0;
            int r = 0;
            for (int i = 0; i < 3; i++)
            {
                if(numbers[0] == numRetry1[0])
                {
                    count++;
                }
            }
            if (count == 3)
            {
                r = 1;
            }
            else if (count == 2)
            {
                r = 2;
            }
            return r;
        }
    }
}
