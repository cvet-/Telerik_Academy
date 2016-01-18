/* Problem 13: Write a Boolean expression that returns if the bit at position p 
 (counting from 0, starting from the right) in given integer number n, has value of 1. */

using System;

class CheckABit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Position: ");
        int position = int.Parse(Console.ReadLine());

        bool isOne = ((number >> position) & 1) ==1;
        Console.WriteLine("Bit at position {0} == 1 -> {1}", position, isOne);
    }
    
}

