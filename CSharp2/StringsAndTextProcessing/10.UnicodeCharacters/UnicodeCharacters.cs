// Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings.

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine(ToUnicode("Hi!"));
    }
    private static string ToUnicode(string text)
    {
        StringBuilder result = new StringBuilder();
        foreach(char ch in text)
        {
            result.Append(string.Format("\\u{0:X4}", (int)ch));
        }
        return result.ToString();
    }
}

