// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with *.
// Print the result string into the console.

using System;

class StringLength
{
    static void Main(string[] args)
    {
        const int length = 20;
        Console.WriteLine(GetInput(length));
    }
    private static string GetInput(int length)
    {
        string text = Console.ReadLine();
        if (text == null)
        {
            return String.Empty;
        }
        if (text.Length<length)
        {
            text = text.Insert(text.Length, new string('*', length - text.Length));
        }
        return text;
    }
}

