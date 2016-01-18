// You are given a sequence of positive integer values written into a string, separated by spaces.
// Write a function that reads these values from given string and calculates their sum.

using System;
class SumInt
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        string[] numbers = Console.ReadLine().Split(' ');

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += int.Parse(number);
        }
        Console.WriteLine(sum);
    }
}

