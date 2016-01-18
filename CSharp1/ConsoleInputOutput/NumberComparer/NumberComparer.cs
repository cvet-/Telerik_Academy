/* Problem 4: Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements. */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers: ");
        Console.WriteLine("The greater number is " +
        Math.Max(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))); // returns the larger of two numbers
    }
}

