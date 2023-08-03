using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using static FundermentalPractice.Complex2;
using System.Collections;

namespace FundermentalPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // charpter 1 Question
            //Console.WriteLine("Hello World!");

            //// 5

            //Console.WriteLine("Good Day!");
            //Console.WriteLine("Good Morning!");


            //// 6

            //Console.WriteLine("AbdulRoheem AbdulLateef");


            //// 7

            //Console.WriteLine("1");
            //Console.WriteLine("101");
            //Console.WriteLine("1001");

            //// 8

            //Console.WriteLine(DateTime.Now);


            //// 9

            // Console.WriteLine(Math.Sqrt(12345));

            //// 10

            //for (int i = 2; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write($"{i}" + "," + " ");
            //    }

            //    else
            //    {
            //        Console.Write(-i +","+ " ");
            //    }
            //}


            // 11

            //Console.Write("Enter your age : ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine($"your age after 10 years will be {age + 10}");


            // 13

            //for (int i = -15; i <= 0; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //int count = -15;
            //while(count <= 0)
            //{
            //    Console.WriteLine(count);
            //    count = count += 3;
            //}


            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            //double d = 0;
            //for (int i = 0; i < 1000 * 1000 * 1000; i++)
            //{
            //         d += 1;
            //}
            //stopWatch.Stop();
            //Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss\\.fffffff}", stopWatch.Elapsed);


            //uint ui = 5U;
            //int i = 5;
            //sbyte sb = 127;
            //decimal m = 30.5M;
            //double d = 30.5D;
            //float f = 30.5F;
            //long l = 5L;
            //ulong ul = 5UL;



            //char ab = '\u0013';
            //Console.WriteLine(ab);
            //char character1 = '\u003A';
            //Console.WriteLine(character1);


            // Chapter 2 Question

            // 3
            //float a = 0.5f;
            //float b = 0.3f;

            //bool equal = Math.Abs(a - b) < 0.000001;

            //Console.WriteLine(equal);

            // 4

            //int a = 256;
            //string hexadecimal = Convert.ToString(a,16);
            //Console.WriteLine(hexadecimal);

            // 5

            //char character = '\u0072';
            //string hexadecimal = Convert.ToString(character,16);
            //Console.WriteLine(hexadecimal);

            // 8

            //string hello = "Hello";
            //string world = hello+"World";
            //object world2 = world;
            //string world3 = (string)world2;
            //Console.WriteLine(world3);

            // 9.Declare two variables of type string and assign them a value “The
            //"use" of quotations causes difficulties.” (without the outer quotes). 
            //In one of the variables use quoted string and in the other do not use it.

            //string quotations1 = "“The \"use\" of quotations causes difficulties.” (without the outer quotes)";
            //string quotations2 = "“The use of quotations causes difficulties.” (without the outer quotes)";
            //Console.WriteLine(quotations1);
            //Console.WriteLine(quotations2);

            //12.A company dealing with marketing wants to keep a data record of its
            //    employees.Each record should have the following characteristic – first
            //    name, last name, age, gender(‘m’ or ‘f’) and unique employee number
            //(27560000 to 27569999). Declare appropriate variables needed to
            //maintain the information for an employee by using the appropriate data
            //types and attribute names.

            //Console.WriteLine("Enter your firstname");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Enter your lastname");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your gender");
            //char gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your employee number");
            //int employeenumber = int.Parse(Console.ReadLine());

            //Console.WriteLine($"your Name is {firstName} {lastName}, am {age} years old, my {gender} at gender, and my employeenumber is {employeenumber} ");


            //13.Declare two variables of type int.Assign to them values 5 and 10
            // respectively.Exchange(swap) their values and print them. 


            //int a = 5;
            //int b = 10;
            //int c = a + b;
            //a = c - a;
            //b = c - b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


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

            //10.To get the individual digits of the number you can divide by 10 and
            //take the remainder of the division by 10:
            //int a = num % 10;
            //int b = (num / 10) % 10;
            //int c = (num / 100) % 10;
            //int d = (num / 1000) % 10;

            // int add = 0;
            // string lastAndFirst= "";
            // string secondAndThird = "";


            //Console.WriteLine("Enter side a : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter side b : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter side c : ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter side d : ");
            //int d = int.Parse(Console.ReadLine());

            // a = add % 10;
            // b = (add / 10) % 10;
            // c = (add / 100) % 10;
            // d = (add / 1000) % 10;



            // add = a + b + c + d;
            // Console.WriteLine($"The addition of the 4 digits is {add} ");
            // Console.WriteLine($"The swap of LastAndFirst is {lastAndFirst}");
            // Console.WriteLine($"The swap of SecondAndThird is {secondAndThird}");


            // Console.WriteLine("Enter a word here" );
            //string word = Console.ReadLine();

            //foreach (var item in word.Reverse())
            //{
            //    Console.Write(item);
            //}

            //int codeRead = 0;
            //Console.WriteLine("Enter a codeRead : ");
            //do
            //{
            //    codeRead = Console.Read();
            //    if (codeRead != 0)
            //    {
            //        Console.Write((char)codeRead);
            //    }
            //}
            //while (codeRead != 10);


            // 1. Write a program that reads from the console three numbers of type int
            // and prints their sum.


            // Console.WriteLine("Enter a number : ");
            // int number = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter a number : ");
            // int number2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Enter a number : ");
            // int number3 = int.Parse(Console.ReadLine());

            // int sum = number + number2 + number3;
            // Console.WriteLine($"The sum of the 3 numbers is {sum}");


            // 2.Write a program that reads from the console the radius "r" of a circle
            // and prints its perimeter and area.

            // Console.WriteLine("Enter a radius : ");
            // int radius = int.Parse(Console.ReadLine());

            // double perimeter = 2 * Math.PI * radius;
            // double area = Math.PI * radius * radius;

            // Console.WriteLine($"The perimeter of the circle is {perimeter}");
            // Console.WriteLine($"The area of the circle is {area}");


            // 3. A given company has name, address, phone number, fax number, web 
            //  site and manager.The manager has name, surname and phone number.
            //Write a program that reads information about the company and its
            // manager and then prints it on the console.


            // Console.WriteLine("Enter a company name : ");
            // string companyName = Console.ReadLine();

            // Console.WriteLine("Enter a company address : ");
            // string companyAddress = Console.ReadLine();

            // Console.WriteLine("Enter a company phone number : ");
            // string companyPhoneNumber = Console.ReadLine();

            // Console.WriteLine("Enter a company fax number : ");
            // string companyFaxNumber = Console.ReadLine();

            // Console.WriteLine("Enter a company website : ");
            // string companyWebsite = Console.ReadLine();

            // Console.WriteLine("Enter a manager name : ");
            // string managerName = Console.ReadLine();

            // Console.WriteLine("Enter a manager surname : ");
            // string managerSurname = Console.ReadLine();

            // Console.WriteLine("Enter a manager phone number : ");
            // string managerPhoneNumber = Console.ReadLine();

            // Console.WriteLine($"Company name : {companyName}");
            // Console.WriteLine($"Company address : {companyAddress}");
            // Console.WriteLine($"Company phone number : {companyPhoneNumber}");
            // Console.WriteLine($"Company fax number : {companyFaxNumber}");
            // Console.WriteLine($"Company website : {companyWebsite}");
            // Console.WriteLine($"Manager name : {managerName}");
            // Console.WriteLine($"Manager surname : {managerSurname}");
            // Console.WriteLine($"Manager phone number : {managerPhoneNumber}");














































































































































            // Batch 10 Assessment 

            //1.

            //int a = 1;
            //int b = 29;  
            //int c = 37;  
            //int d = 47;  
            //int e = 5;
            //int f = 66;
            //int g = 45;
            //int h = 8;
            //int i = 9;
            //int j = 10;

            //int total = a + b + c + d + e + f + g + h + i + j;

            //Console.WriteLine(total);

            //2.
            //int large = 0;
            //for (int m = 0; m < 5; m++)
            //{
            //    Console.WriteLine("Enter a number:");
            //    int number = int.Parse(Console.ReadLine());
            //    if (number > large)
            //    {
            //        large = number;
            //    }

            //}
            //Console.WriteLine($"The greatest number is {large}");

            //3.
            //Console.WriteLine("Enter a number:");
            //int num4 = int.Parse(Console.ReadLine());

            //switch (num4)
            //{
            //        case 1:
            //        Console.WriteLine("January");
            //        break;

            //        case 2:
            //        Console.WriteLine("Febuary");
            //        break;

            //        case 3:
            //        Console.WriteLine("March");
            //        break;

            //        case 4:
            //        Console.WriteLine("April");
            //        break;

            //        case 5:
            //        Console.WriteLine("May");
            //        break;

            //        case 6:
            //        Console.WriteLine("June");
            //        break;

            //        case 7:
            //        Console.WriteLine("July");
            //        break;

            //        case 8:
            //        Console.WriteLine("August");
            //        break;

            //        case 9:
            //        Console.WriteLine("September");
            //        break;

            //        case 10:
            //        Console.WriteLine("October");
            //        break;

            //        case 11:
            //        Console.WriteLine("November");
            //        break;

            //        case 12:
            //        Console.WriteLine("December");
            //        break;

            //        default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}


            //4.

            //Console.WriteLine("Enter a number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a number:");
            //int num2 = int.Parse(Console.ReadLine());
            //int triple = 0;
            //if (num1 == num2)
            //{
            //  triple =  (num1 + num2) * 3;
            //    Console.WriteLine($"The triple of the number is {triple}");
            //}

            //else
            //{
            //    triple = num1 + num2;
            //    Console.WriteLine("The sum of number is " + triple);
            //}

            //  6

            //Console.WriteLine("Enter a number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a number:");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter a number:");
            //int num3 = int.Parse(Console.ReadLine());


            //if (num1 == num2 && num2 == num3 && num3 == num1 )
            //{
            //    Console.WriteLine("The three sides is equal");
            //}

            //else if (num1 == num2 || num2 == num3 || num3 == num1)
            //{
            //    Console.WriteLine("The two sides are equal");
            //}

            //else
            //{
            //    Console.WriteLine("No equal");
            //}

            // 9

            //Console.WriteLine("Enter a leter:");
            //string alphabet = Console.ReadLine();

            //if (alphabet == "a" || alphabet == "A" && alphabet == "e" || alphabet == "E" &&  alphabet == "i" || alphabet == "I" && 
            //    alphabet == "o" || alphabet == "O" && alphabet == "u" || alphabet == "U")

            //{
            //    Console.WriteLine($"{alphabet} is a vowel letter");
            //}

            //else
            //{
            //    Console.WriteLine($"{alphabet} is a consonant letter");
            //}



            //10.Write a program that reads an integer between 0 and 1000 and adds all the digits in the integer. 
            //    For example, if an integer is 932, the sum of all its digits is 14.
            //Hint: Use the % operator to extract digits, and use the / operator to remove the
            //extracted digit.For instance, 932 % 10 = 2 and 932 / 10 = 93.


            //Console.WriteLine("Enter your bonus score:");
            //int score = int.Parse(Console.ReadLine());
            //int result = 0;
            //if (score > 0  && score <= 1000 )
            //{
            //    result += score % 10;
            //    result += score % 10;
            //    result += score / 100;



            //    Console.WriteLine(result);
            //}




            //Console.WriteLine("What is your age ?");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("your age" + " " + " age");
            //string a = "beer";
            //Console.WriteLine($"the name of the variable is {0}");

            //Console.WriteLine("Input your simple caculator: \n press 1, for addition \n press 2, for subtraction \n press 3, for multiplication. ");
            //int calculate = int.Parse(Console.ReadLine());

            //switch (calculate)
            //{
            //    case 1:
            //        if (calculate == 1)
            //        {
            //            Console.WriteLine("enter your number1 ");
            //            int number = int.Parse(Console.ReadLine());

            //            Console.WriteLine("enter your number2 ");
            //            int number1 = int.Parse(Console.ReadLine());

            //            int total = number + number1;
            //            Console.WriteLine($"The addtion of {number} + {number1} = {total}");
            //        }
            //        break;


            //    case 2:
            //        if (calculate == 2)
            //        {
            //            Console.WriteLine("enter your number1 ");
            //            int number = int.Parse(Console.ReadLine());

            //            Console.WriteLine("enter your number2 ");
            //            int number1 = int.Parse(Console.ReadLine());

            //            int total = number - number1;
            //            Console.WriteLine($"The subtract of {number} - {number1} = {total}");
            //        }

            //        break;

            //    case 3:
            //        if (calculate == 3)
            //        {
            //            Console.WriteLine("enter your number1 ");
            //            int number = int.Parse(Console.ReadLine());

            //            Console.WriteLine("enter your number2 ");
            //            int number1 = int.Parse(Console.ReadLine());

            //            int total = number * number1;
            //            Console.WriteLine($"The multiplication of {number} * {number1} = {total}");
            //        }
            //        break;

            //    default:
            //        {
            //            Console.WriteLine("Invalid Input");
            //        }
            //        break;

            //}


            //int[,] arry = {
            //    {3,5,6 },
            //    {6,9,6 },
            //    {9,4,2 }
            //};
            //Console.WriteLine(diagonaldiff(arry));





            //   CHARACTER


             //char ch = 'a';
            // Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            // ch = 'b';
            // Console.WriteLine("The code of '" + ch + "' is: " + (int)ch);
            //  ch = 'c';
            // Console.WriteLine("The code of '" + ch + "' is: " + (int)ch); 
            // ch = 'y';
            // Console.WriteLine("The code of " + ch + " is: " + (int)ch);
            // ch = '1';
            // Console.WriteLine("The code of " + ch + " is: " + (int)ch);


            // NULLABLE

            // int a = 19392;
            // int? b = a;
            // Console.WriteLine(b.Value);

           


            Complex complex = new Complex();
            complex.Real = 123.2;
            Console.WriteLine(complex.Real);     





















        }

        //static int diagonaldiff(int [,] arr)
        //{
        //    int leftSum = 0;
        //    int rightSum = 0;
        //    for (int i=0; i<arr.Length; i++)
        //    {
        //        leftSum += arr[i, i];
        //        rightSum += arr[i, arr.Length-1-i];
        //    }
        //    int diff = Math.Abs(leftSum - rightSum);
        //    return diff;
        //}
        //static List<int> CompareTriple(List<int> a, List<int> b)
        //{
        //    List<int> compare = new List<int>();

        //    int count1 = 0;
        //    int count2 = 0;

        //    for (int i = 0; i < b.Count(); i++)
        //    {
        //        if (a[i] == b[i])
        //        {
        //            count1++;
        //        }

        //        else if (a[i] == b[i])
        //        {
        //            count2++;
        //        }


        //    }

        //    compare.Add(count1);
        //    compare.Add(count2);
        //    return compare;
        //}




    }
}




