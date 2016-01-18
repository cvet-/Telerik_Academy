﻿using System;

class CompareArrays
{
    static void Main()
    {
        
        Console.Write("Enter the lenght of the first array:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter first array: ");        
        int[] firstArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the lenght of the second array:");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter second array: ");
        int[] secondArr = new int[m];
        for (int i = 0; i < m; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        if (firstArr.Length != secondArr.Length)
        {
            Console.WriteLine("Enter arrays with equal lenght");
        }

        for (int i = 0; i <= firstArr.Length - 1; i++)
        {            
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= secondArr.Length - 1; i++)
        {
             secondArr[i] = int.Parse(Console.ReadLine());
        }

        bool areEqual = true;
        for (int i = 0; i < secondArr.Length; i++)
        {
            if (firstArr[i] != secondArr[i])
            {
                areEqual = false;
                break;
            }
        }

        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }
}