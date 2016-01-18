/* Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm. */

using System;
using System.Collections.Generic;

class BinarySearch
{   static void Main()
    {
        int[] array = { 1,2,3,4,5};
        int key = 3;
        Console.WriteLine(BinSearch(array, key));
    }
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array); // Sorts the array

        int last = array.Length - 1;
        int first = 0;
        while (first <= last)
        {
            int middle = (first + last) / 2;

            if (key > array[middle])
            {
                first = middle + 1;
            }
            else if (key < array[middle])
            {
                last = middle - 1;
            }
            else
            {
                return middle;
            }
        }
        return -1;
    }
 
}