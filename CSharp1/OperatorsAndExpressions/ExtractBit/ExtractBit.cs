/* Problem 11: Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0. */

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        
        int extractBit = (int)(number >> 3) & 1;
        Console.WriteLine("bit #3 is: {0}",extractBit);

    }
}
