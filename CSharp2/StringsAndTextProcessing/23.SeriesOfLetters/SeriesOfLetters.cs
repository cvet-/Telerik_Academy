// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaab";
        StringBuilder result = new StringBuilder();

        char previous = text[0];

        result.Append(previous);

        for (int i = 1; i < text.Length; i++)
        {
            if (previous != text[i])
            {
                result.Append(text[i]);
            }
            previous = text[i];
        }
        Console.WriteLine(result.ToString());
    }
}

