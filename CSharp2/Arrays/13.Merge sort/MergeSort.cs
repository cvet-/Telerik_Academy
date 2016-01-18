/* Write a program that sorts an array of integers using the Merge sort algorithm. */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class MergeSort
{
    static void Main(string[] args)
    {

        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        int len = 9;
        Console.WriteLine("MergeSort!");
        sortmethod(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
            Console.WriteLine(numbers[i]);
    }
    static public void MergeMethod(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, leftEnd, numElements, tempPosition;
        leftEnd = (mid - 1);
        tempPosition = left;
        numElements = (right - left + 1);
        while ((left <= leftEnd) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tempPosition++] = numbers[left++];
            else
                temp[tempPosition++] = numbers[mid++];
        }
        while (left <= leftEnd)
            temp[tempPosition++] = numbers[left++];
        while (mid <= right)
            temp[tempPosition++] = numbers[mid++];
        for (i = 0; i < numElements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }

    }
    static public void sortmethod(int[] numbers, int left, int right)
    {
        int mid;
        if (right > left)
        {
            mid = (right + left) / 2;
            sortmethod(numbers, left, mid);
            sortmethod(numbers, (mid + 1), right);
            MergeMethod(numbers, left, (mid + 1), right);

        }
    }
   
}
