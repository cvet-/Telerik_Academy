﻿/* Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum. */

using System;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];
        for (int i = 0; i < n; i++)
        {            
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        string bestSeq = "";
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLen = myArray.Length;
        for (int i = 0; i < arrayLen; i++)
        {
            string currentSeq = "";

            if (i + k > arrayLen)
            {
                break;
            }

            for (int j = i; j < i + k; j++)
            {
                sum = sum + myArray[j];
                currentSeq = currentSeq + ' ' + myArray[j];
            }

            if (sum > bestSum)
            {
                bestSeq = currentSeq;
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine(bestSeq);
        Console.WriteLine(bestSum);

    }
}
