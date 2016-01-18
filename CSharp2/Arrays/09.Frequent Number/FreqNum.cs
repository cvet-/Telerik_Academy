/* Write a program that finds the most frequent number in an array. */

using System;
using System.Collections.Generic;

class FreqNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int length = int.Parse(Console.ReadLine());

        int[] array1 = new int[length];
        for (int i = 0; i < length; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array1.Length - 1; i++)
        {
            for (int j = i + 1; j < array1.Length; j++)
            {
                if (array1[i] >= array1[j])
                {
                    int a = array1[i];
                    array1[i] = array1[j];
                    array1[j] = a;
                }
            }
        }
        int counter = 0;
        int bigCounter = 0;
        int whatNum = 0;
        for (int i = 0; i < array1.Length - 1; i++)
        {
            if (array1[i] == array1[i + 1])
            {
                counter++;
                if (bigCounter <= counter)
                {
                    bigCounter = counter;
                    whatNum = array1[i];
                }
            }
            else
            {
                counter = 0;
            }
        }
        Console.WriteLine("{0} ({1} times)", bigCounter + 1, whatNum);
    }
}
