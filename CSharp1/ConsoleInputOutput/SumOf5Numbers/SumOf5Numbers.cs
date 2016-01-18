// Problem 7: Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers, separated by space: ");
        string strNumbers = Console.ReadLine();
        string[] numbers = strNumbers.Split(new char[] { '\u0020' }, // ASCII u0020 = space
            StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i]);
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}
