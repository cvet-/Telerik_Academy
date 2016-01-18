﻿/* You are given an array of strings. Write a method that sorts the array by the length of its elements 
 (the number of characters composing them). */

using System;

class SortByStringLength
{
    static void Main()
    {
        string[] arr = {"Alan Turing", "Ada", "Vincent van Gogh" };
        Array.Sort(arr, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in arr)
        {
            Console.WriteLine(element);
        }
    }
}

