/* Problem 12: Write an expression that extracts from given integer n the value of given bit at index p. */

using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            uint number = uint.Parse(Console.ReadLine());
            
            Console.Write("Position: ");
            int position = int.Parse(Console.ReadLine());

            int extractBit = (int)(number >> position) & 1;
            Console.WriteLine("Bit at position {0} is: {1}", position, extractBit);
        }
    }

