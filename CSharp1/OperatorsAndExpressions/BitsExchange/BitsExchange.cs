/* Problem 15: Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. */

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        for (int i = 3, j = 24; i < 6; i++, j++)    // for loop for numbers from 3 to 5 and 24 to 26, i increases value till it reaches 3
        {                                           //and j reaches 26
            if (((number >> i) & 1) != ((number >> j) & 1)) // Checks if the bits are different
            {
                int firstPosition = i;                      
                int secondPosition = j;
                number ^= (1 << firstPosition);
                number = number ^ (1 << secondPosition);       // Exchanging the positions of the bits
            }
        }
        Console.WriteLine("Result: " + number);
    }


}
