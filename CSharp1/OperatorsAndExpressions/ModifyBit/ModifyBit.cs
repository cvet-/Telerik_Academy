/* Problem 14: We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold 
 the value v at the position p from the binary representation of n while preserving all other bits in n. */

using System;

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());

        if (((number >> position) & 1) != value)
        {
            number = number ^ (1 << position);
        }

        Console.WriteLine("Result: " + number);              
    }
}

