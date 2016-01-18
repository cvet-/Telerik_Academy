/* Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop. */

using System;
using System.Numerics;

class CalculateN
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter K = ");
            string numberStr = Console.ReadLine();
            int numK = int.Parse(numberStr);
            Console.Write("Enter N = ");
            numberStr = Console.ReadLine();
            int numN = int.Parse(numberStr);
            if (numN <= 1 || numK >= numN || numK < 1 || numN > 100 || numK >= 100)
            {
                Console.WriteLine("Invalid Input");
            }
            else
            {
               
                BigInteger resultDivision = 1;
                for (int i = numN; i > numK; i--)
                {
                    resultDivision *= i;
                }
                Console.WriteLine("RESULT = {0}", resultDivision);
            }
            Console.ReadLine();
        }
    }
}