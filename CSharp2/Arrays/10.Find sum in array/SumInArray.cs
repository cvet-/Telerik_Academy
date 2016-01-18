/* Write a program that finds in given array of integers a sequence of given sum S (if present). */

using System;

class SumInArray
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
       
        Console.WriteLine("Enter sumS:");
        int sumS = int.Parse(Console.ReadLine());
        int currentSum = array[0];

        int startIndex = 0;
        int endIndex = 0;
        int CurrSum = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            CurrSum += array[i];
            startIndex = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                CurrSum += array[p];
                endIndex = p;
                if (CurrSum == sumS)
                {
                    for (int k = startIndex; k <= endIndex; k++)
                    {
                        Console.WriteLine(array[k]);
                    }
                    return;
                }
            }
            CurrSum = 0;
        }
        Console.WriteLine("The sumS is not present in the array.");
    }
}
