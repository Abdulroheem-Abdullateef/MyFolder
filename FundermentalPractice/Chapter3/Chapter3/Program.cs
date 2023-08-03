using System;

namespace Chapter3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /// Chapter 3

            // 1.Write an expression that checks whether an integer is odd or even.

            //Console.WriteLine("Enter a number");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            // }


            // 2. Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.

            // bool check = true;

            // Console.WriteLine("Enter a number : ");
            //int number = int.Parse(Console.ReadLine());

            //  if (number % 5 == 0 || number % 7 == 0)
            //  {
            //      Console.WriteLine(check);
            //  }

            //  else
            //  {
            //      check = false;
            //      Console.WriteLine(check);
            //  }


            //3. Write an expression that looks for a given integer if its third digit (right to left) is 7.
            // 3. Divide the number by 100 and save it in a new variable, which then divide by 10 and take the remainder.
            // The remainder of the division by 10 is the third digit of the original number. Check if it is equal to 7.
            //Console.WriteLine("Enter a number : ");
            //int number = int.Parse(Console.ReadLine());
            //int div = 0;
            //int remainder = 0;

            //div = number / 100;
            //remainder = div / 10;
            //remainder = remainder / 10;

            //if (remainder == 7)
            //{
            //    Console.WriteLine("The third number is equal to 7 ");
            //}


            //  4.Write an expression that checks whether the third bit in a given integer is 1 or 0.
            //  4. Use bitwise "AND" on the current number and the number that has 1 only in the third bit (i.e. number 8, if bits start counting from 0).
            //  If the returned result is different from 0 the third bit is 1: int num = 25; bool bit3 = (num & 8) != 0;




            // 5. Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            // 5. The formula for trapezoid surface is: S = (a + b) * h / 2.

            //Console.WriteLine("Enter a side A : ");
            //int sideA = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a side B : ");
            //int sideB = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a side H : ");
            //int height = int.Parse(Console.ReadLine());

            //int areaOfTrapezoid = (sideA + sideB) * height / 2;

            //Console.WriteLine($"The area of trapezoid is {areaOfTrapezoid}");



            //  6.Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            // 6.Search the Internet for how to read integers from the console and use the formula for rectangle area calculation.
            // If you have difficulties see instructions on the next problem.

            //Console.WriteLine("Enter a side : ");
            //int side = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a height : ");
            //int height = int.Parse(Console.ReadLine());

            //int areaOfRectangle = side * height;

            //Console.WriteLine($"The area of rectangle is {areaOfRectangle}");


            // 7. The gravitational field of the Moon is approximately 17% of that on the 
            // Earth.Write a program that calculates the weight of a man on the
            //moon by a given weight on the Earth.

            //Console.WriteLine("Enter the weight  : ");
            //int weight = int.Parse(Console.ReadLine());
            //double gravitational = (double) 17/100 * weight;

            //Console.WriteLine(gravitational);

            // 8. Write an expression that checks for a given point {x, y} if it is within 
            //the circle K({ 0, 0}, R = 5). Explanation: the point { 0, 0} is the center of
            //the circle and 5 is the radius.
            // 8.Use the Pythagorean Theorem a2 + b2 = c2
            //.The point is inside the circle
            //when(x * x) + (y * y) ≤ 5 * 5.

            //Console.WriteLine("Enter side x : ");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter side y : ");
            //int y = int.Parse(Console.ReadLine());

            //bool pythagoreanResult =  (x * x) + (y * y) <= 5 * 5;
            //Console.WriteLine(pythagoreanResult);


            // 9. Write an expression that checks for given point {x, y} if it is within the 
            //circle K({ 0, 0}, R = 5) and out of the rectangle[{ -1, 1}, { 5, 5}]. 
            //Clarification: for the rectangle the lower left and the upper right corners
            //are given.
            // 9.Use the code from the previous task and add a check for the
            // rectangle.A point is inside a rectangle with walls parallel to the axes,
            // when in the same time it is right of the left wall, left of the right wall,
            // down from the top wall and above the bottom wall.

            //Console.WriteLine("Enter side x : ");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter side y : ");
            //int y = int.Parse(Console.ReadLine());

            //bool retangle =  (x * x) + (y * y) <= 5 * 5;
            //Console.WriteLine(retangle);


            // 10.Write a program that takes as input a four-digit number in format abcd
            // (e.g. 2011) and performs the following actions:
            // -Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
            //  - Prints on the console the number in reversed order: dcba(in our
            // example 1102).
            // - Puts the last digit in the first position: dabc(in our example 1201).
            // - Exchanges the second and the third digits: acbd(in our example
            //2101).

            //Console.WriteLine("Enter a four-digit number : ");
            //int number = int.Parse(Console.ReadLine());

            //int firstDigit = number / 1000;
            //int secondDigit = (number / 100) % 10;
            //int thirdDigit = (number / 10) % 10;
            //int fourthDigit = number % 10;

            //int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

            //Console.WriteLine($"The sum of digits is {sumOfDigits}");
            //Console.WriteLine($"The number in reversed order is {fourthDigit}{thirdDigit}{secondDigit}{firstDigit}");
            //Console.WriteLine($"The last digit in the first position is {fourthDigit}{firstDigit}{secondDigit}{thirdDigit}");
            //Console.WriteLine($"The second and the third digits exchanged is {firstDigit}{thirdDigit}{secondDigit}{fourthDigit}");



            //11.We are given a number n and a position p.Write a sequence of
            //operations that prints the value of the bit on the position p in the
            //number(0 or 1).Example: n = 35, p = 5-> 1.Another example: n = 35, 
            //p = 6-> 0.


            //Console.WriteLine("Enter a number : ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a position : ");
            //int position = int.Parse(Console.ReadLine());

            //int mask = 1 << position;
            //int nAndMask = number & mask;
            //int bit = nAndMask >> position;

            //Console.WriteLine(bit);





        }
    }
}
