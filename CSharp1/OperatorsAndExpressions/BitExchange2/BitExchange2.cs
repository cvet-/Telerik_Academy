/* Problem16: Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} 
 of a given 32-bit unsigned integer. */

using System;

class BitExchange2
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter position p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter position q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter step: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = p, j = q, l = k; (i <= 32 && j <= 32) && l > 0; i++, j++, l--) // for loop for position P, position Q and Step K
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                int firstPosition = i;
                int secondPosition = j;
                number ^= (1 << firstPosition);
                number = number ^ (1 << secondPosition);

            }
        }
        Console.WriteLine("Result: {0}", number);
    }

}

