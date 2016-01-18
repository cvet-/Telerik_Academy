/* In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). */

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

        Console.WriteLine(result);
    }
    private static BigInteger Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
