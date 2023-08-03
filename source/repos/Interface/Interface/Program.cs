using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(12);
            Console.WriteLine(circle.GetName());
            Console.WriteLine(circle.GetArea());

            var square = new Square(12);
            Console.WriteLine(square.GetName());
            Console.WriteLine(square.GetArea());


        }
    }
}
