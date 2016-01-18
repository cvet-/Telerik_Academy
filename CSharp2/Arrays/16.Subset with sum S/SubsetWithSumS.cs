/*We are given an array of integers and a number S.
Write a program to find if there exists a subset of the elements of the array that has a sum S.*/
﻿
using System;

class SubsetWithSumS
{
    static void Main()
    {
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("S:");
        int s = int.Parse(Console.ReadLine());

        int[] arr = new int[n];       
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool isThere = false;

        for (int i = 0; i < (2 << n) - 1 && !isThere; i++)
        {
            int sum = 0;

            for (int j = 0; j < n && !isThere; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += arr[j];
                }

                if (sum == s)
                {
                    Console.WriteLine("yes");
                    isThere = true;
                }

            }
        }

    }
}