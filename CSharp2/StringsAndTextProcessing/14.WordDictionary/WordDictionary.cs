// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

using System;
using System.Collections.Generic;
class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter a word to search for: ");
        string word = Console.ReadLine();
        Console.WriteLine("{0} - {1}", word, GetExplanation(word));
    }
    private static string GetExplanation(string word)
    {
        word = word.Trim();
        var dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "Platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");

        foreach (var entry in dictionary)
        {
            if (entry.Key.ToLowerInvariant() == word.ToLowerInvariant())
            {
                return entry.Value;
            }
        }
        return "word not found";
    }
}
