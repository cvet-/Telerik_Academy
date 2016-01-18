/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
find the smallest from the rest, move it at the second position, etc. */

using System;
using System.Collections.Generic;

class Sort
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        int minValue = int.MaxValue;
        int minIndex = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (minValue > arr[j])
                {
                    minValue = arr[j];
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = minValue;
            arr[minIndex] = temp;
        }
        Console.WriteLine(string.Join(", ",arr));
    }
}
