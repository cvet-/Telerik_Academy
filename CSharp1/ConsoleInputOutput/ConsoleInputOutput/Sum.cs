//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

    class Sum
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            double sum = 0;
            sum = num1 + num2 + num3;
            Console.WriteLine("The sum of the numbers is: {0}", sum);


        }
    }

