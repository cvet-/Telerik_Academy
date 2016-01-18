//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Security;

class RemoveWords
{
    static void Main()
    {
        try
        {
            string[] wordsToRemove = File.ReadAllLines(@"../../remove_words.txt");
            string text = File.ReadAllText(@"../../input.txt");

            foreach (string word in wordsToRemove)
            {
                text = text.Replace(word, string.Empty);
            }

            File.WriteAllText("../../output.txt", text);
            Console.WriteLine("File is located in the project's directory.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path is a zero-length or contains invalid characters.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path is too long.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred.");
        }
        
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}
