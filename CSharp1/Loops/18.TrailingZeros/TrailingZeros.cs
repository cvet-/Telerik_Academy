/* Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000. */

using System;
using System.Numerics;

public class TrailingZeros
{
    public static void Main(string[] args)
    {
        checked
        {
            long numN;
            do
            {
                Console.Write("Enter a number: ");
            }
            while (!long.TryParse(Console.ReadLine(), out numN) || numN < 1);

            // Just in case we'll calculate and N!:
            BigInteger factorialN = 1;
            for (long i = numN; i > 1; i--)
            {
                factorialN *= i;
            }

            // Calculate count of Zeroes in N!, without calculating N! itself:
            long countZeroes = 0;
            long quotient = numN;
            do
            {
                quotient /= 5;
                countZeroes += quotient;
            }
            while (quotient > 1);

            Console.WriteLine("Factorial of number {0} is: {1}\n", numN, factorialN);
            Console.WriteLine("Trailing Zeroes in {0}! is: {1} !", numN, countZeroes);
        }
    }
}
