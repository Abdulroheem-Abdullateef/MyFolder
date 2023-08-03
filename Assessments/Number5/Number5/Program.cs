using System;

namespace Number5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your address ");
            string address =Console.ReadLine();

            Console.WriteLine("Enter your item name ");
            string itemname = Console.ReadLine();

            Console.WriteLine("Enter your item sku ");
            string itemsku = Console.ReadLine();

            Console.WriteLine("Enter your item quantity ");
            string itemquantity = Console.ReadLine();

            Console.WriteLine("Enter your item price ");
            string itemprice = Console.ReadLine();


            Console.WriteLine($" your name is {name} ");

            Console.WriteLine($" your address is {address} ");

            Console.WriteLine($" your itemname is {itemname} ");

            Console.WriteLine($" your item quantity is {itemquantity} ");

            Console.WriteLine($" your item sku is {itemsku} ");

            Console.WriteLine($" your itemprice is {itemprice} ");
        }
    }
}
