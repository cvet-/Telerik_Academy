// Write a program that reads a string, reverses it and prints the result at the console 

using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter word to reverse: ");
        string word = Console.ReadLine();
        Console.WriteLine(Reverse(word));
    }
    private static string Reverse(string text)
    {
        char[] characters = text.ToCharArray();
        Array.Reverse(characters);
        return new string(characters);
    }
}

