/* Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. */
﻿
using System;

class CombinationsOfSet
{

    static int n;
    static int k;
    static int[] result;

    static void Main()
    {
        Console.Write("Enter N: ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        k = int.Parse(Console.ReadLine());
        result = new int[k];
        Combinations(0, 0);
    }

    private static void Combinations(int position, int currentIndex)
    {
        if (position == result.Length)
        {
            foreach (var item in result)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            return;
        }

        for (int i = currentIndex + 1; i <= n; i++)
        {
            result[position] = i;
            currentIndex++;
            Combinations(position + 1, currentIndex);
        }

    }
}