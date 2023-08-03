using System;

namespace Number7
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum=0;
            for (int i = 0; i < 5; i++)
            {
               
                Console.WriteLine("Your store name ");
                string name = Console.ReadLine();


                Console.WriteLine("Your Address ");
                string address = Console.ReadLine();


                Console.WriteLine("Your item Name ");
                string itemname = Console.ReadLine();


                Console.WriteLine("Your sku ");
                string itemsku = Console.ReadLine();


                Console.WriteLine("Your quantity ");
                int quantity = int.Parse(Console.ReadLine());


                Console.WriteLine("Your price ");
               int price = int.Parse(Console.ReadLine());


                Console.WriteLine("Your item number ");
                int itemnumber = int.Parse(Console.ReadLine());

                if (name!=" "&&address!=" "&&itemname!=" "&& itemsku!=" "&&itemnumber>=0&&price>=0&&quantity>=0)
                {
                    Console.WriteLine($" your name is {name}");

                    Console.WriteLine($" your address is {address}");

                    Console.WriteLine($" your itemname is {itemname}");

                    Console.WriteLine($" your itemnumber is {itemnumber}");

                    Console.WriteLine($" your itemsku is {itemsku}");

                    Console.WriteLine($" your quantity is {quantity}");

                    Console.WriteLine($" your price is {price}");




                }

                else 
                {
                    Console.WriteLine("your store name, itemname, and address, must not empty  ");
                }
            }







        }
    }
}
