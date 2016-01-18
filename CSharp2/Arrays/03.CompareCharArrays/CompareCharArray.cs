/* Write a program that compares two char arrays lexicographically (letter by letter). */

using System;

class CompareCharArray
{
     static void Main()
    {
        // First Array        
        Console.Write("Enter first word: ");
        char[] firstWord = Console.ReadLine().ToCharArray();
        

        // Second Array
        Console.Write("Enter second word: ");
        char[] secondWord = Console.ReadLine().ToCharArray();

        string first = string.Join("", firstWord);
        int length = Math.Min(firstWord.Length, secondWord.Length);
        for (int i = 0; i < length; i++)
        {
            if (firstWord [i]>secondWord[i])
            {
                first = string.Join("", secondWord);
                break;
            }
        }
        Console.WriteLine("Lexicographically first is: {0}", first);
    }
}
