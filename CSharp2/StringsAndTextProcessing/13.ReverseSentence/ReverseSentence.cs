// Write a program that reverses the words in given sentence.

using System;
using System.Collections.Generic;

class ReverseSentence
{
    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        ReverseSentance(sentence);
    }
    static void ReverseSentance(string sentance)
    {
        string[] words = sentance.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
        Queue<string> punctuation = new Queue<string>();
        int i = 0;
        while (i < sentance.Length)
        {
            switch (sentance[i])
            {
                case ' ':
                    punctuation.Enqueue(" ");
                    break;
                case ',':
                    punctuation.Enqueue(", ");
                    i++;
                    break;
                case '!':
                    punctuation.Enqueue("!");
                    break;
                case '?':
                    punctuation.Enqueue("?");
                    break;
                case '.':
                    punctuation.Enqueue(".");
                    break;
                default:
                    break;
            }
            i++;
        }
        for (int j = words.Length - 1; j >= 0; j--)
        {
            Console.Write("{0}{1}", words[j], punctuation.Dequeue());
        }
        Console.WriteLine();
    }
}

