/* Write a program that sorts an array of integers using the Quick sort algorithm. */﻿

using System;

class QuickSort
{
    static void Main()
    {
        int[] arr = { 2,3,5,8,9,10,7,1,4,6};
        QuickSortAlg(arr, 0, 9);
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }
    static void QuickSortAlg(int[] arr, int left, int right)
    {
        int originalLeft = left;
        int originalRight = right;
        int pivot = arr[(left + right) / 2];

        while (left < right)
        {
            while (pivot > arr[left])
            {
                left++;
            }
            while (pivot < arr[right])
            {
                right--;
            }
            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }
        if (originalLeft < right)
        {
            QuickSortAlg(arr, originalLeft, right);
        }
        if (left < originalRight)
        {
            QuickSortAlg(arr, left, originalRight);
        }
    }   
}