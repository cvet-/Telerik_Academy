// Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Linq;

class TheBiggestOfFiveNumbers
{
    static void Main(string [] args)
    {
        Console.WriteLine("Enter five numbers: ");
        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            max = Math.Max(max, numbers[i]);
        }
        Console.WriteLine("The biggest of five numbers is: {0}", max);

    }
}

