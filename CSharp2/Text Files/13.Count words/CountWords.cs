//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Linq;
using System.Security;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main(string[] args)
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            string text = File.ReadAllText("../../test.txt");

            string[] wordsCountOutput = (from w in words                               
                                         let wordCount = Regex.Matches(text, w).Count  
                                         orderby wordCount descending                  
                                         select w + " - " + wordCount)                 
                                         .ToArray();                                    

            File.WriteAllText("../../results.txt", string.Join("\n", wordsCountOutput));
            Console.WriteLine("File is located in the project's directory.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length or contains invalid characters.");
        }       
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path is too long.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
       
    }
}
