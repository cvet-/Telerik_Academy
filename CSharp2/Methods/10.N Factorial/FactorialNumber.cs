//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class FactorialNumber
{
    static BigInteger CalcualteFactorial(int[] array, int n)
    {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * array[i];
        }
        return result;
    }

    static void Main()
    {
        int[] hundredNumbers = new int[100];
        for (int i = 1; i < 100; i++)
        {
            hundredNumbers[i] = i;

        }
        foreach (var item in hundredNumbers)
        {
            Console.WriteLine(CalcualteFactorial(hundredNumbers, item));
        }
    }
}
