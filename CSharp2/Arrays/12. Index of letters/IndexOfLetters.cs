/* Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array. */

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        int first = (int)'A';
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(first + i);
        }

        Console.Write("Enter word (use capital letters): ");
        string word = Console.ReadLine();
        foreach (char item in word)
        {
            Console.WriteLine(BinSearch(alphabet, 0, 25, item));
        }
    }
    static int BinSearch(char[] arr, int left, int right, char value)
    {
        if (left > right)
        {
            return -1;
        }
        int middle = (left + right) / 2;
        if (arr[middle] == value)
        {
            return middle;
        }
        else if (arr[middle] < value)
        {
            return BinSearch(arr, middle + 1, right, value);
        }
        else
        {
            return BinSearch(arr, left, middle - 1, value);
        }
    }

  
}