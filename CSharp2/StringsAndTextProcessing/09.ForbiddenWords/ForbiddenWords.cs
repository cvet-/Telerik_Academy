// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks.
// Example text: Microsoft announced its next generation PHP compiler today. 
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
// Forbidden words: PHP, CLR, Microsoft
// The expected result: ********* announced its next generation *** compiler today. 
// It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;

class ForbiddenWords
{
    static void Main()
    {
        var forbiddenWords = new[] { "PHP", "CLR", "Microsoft"};
        string text = @" Microsoft announced its next generation PHP compiler today. 
It is based on .NET Framework 4.0 and is implemented 
as a dynamic language in CLR.";

        Console.WriteLine(ReplaceForbiddenWord(text, forbiddenWords));
    }

    private static string ReplaceForbiddenWord (string text, string[] forbiddenWords)
    {
        const char asterisks = '*';
        foreach (var forbiddenWord in forbiddenWords)
        {
            text = text.Replace(forbiddenWord, new string(asterisks, forbiddenWord.Length));
        }
        return text;
    }
}

