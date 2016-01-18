//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
class Program
{
    static void Main()
    {
        const string sourcePath = @"../../InputFile.txt";

        try
        {
            FileReplaceWord(sourcePath, "start", "final");
            Console.WriteLine("Words replaced successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // Problem 7
    private static void FileReplaceSubstring(string source, string oldString, string newString)
    {
        if (!File.Exists(source))
        {
            throw new FileNotFoundException();
        }
        const string targetPath = @"../../temp.txt";
        var streamReader = new StreamReader(source);
        var streamWriter = new StreamWriter(targetPath);

        try
        {
            string currentLine;
            do
            {
                currentLine = streamReader.ReadLine();
                if (currentLine != null)
                {
                    currentLine = currentLine.Replace(oldString, newString);
                }

                streamWriter.WriteLine(currentLine);
            } while (currentLine != null);
        }
        catch (Exception ex)
        {
            throw new Exception("Something went wrong while tring to read the file.", ex.InnerException);
        }
        finally
        {
            streamReader.Close();
            streamWriter.Close();
        }

        try
        {
            ReplaceFile(source, targetPath);
        }
        catch (Exception)
        {
            throw;
        }
    }

    // Problem 8
    private static void FileReplaceWord(string source, string wordToReplace, string newWord)
    {
        if (!File.Exists(source))
        {
            throw new FileNotFoundException();
        }

        wordToReplace = wordToReplace.Trim();

        const string targetPath = @"../../temp.txt";
        var streamReader = new StreamReader(source);
        var streamWriter = new StreamWriter(targetPath);

        try
        {
            string currentLine;
            do
            {
                currentLine = streamReader.ReadLine();
                if (currentLine != null)
                {
                    if (IsWord(currentLine, wordToReplace))
                    {
                        currentLine = currentLine.Replace(wordToReplace, newWord);
                    }
                }

                streamWriter.WriteLine(currentLine);
            } while (currentLine != null);
        }
        catch (Exception ex)
        {
            throw new Exception("Something went wrong while trying to read the file.", ex.InnerException);
        }
        finally
        {
            streamReader.Close();
            streamWriter.Close();
        }

        try
        {
            ReplaceFile(source, targetPath);
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static void ReplaceFile(string source, string targetPath)
    {
        try
        {
            File.Copy(targetPath, source, true);
        }
        catch (Exception ex)
        {
            throw new Exception("Unable to replace file.", ex.InnerException);
        }
        finally
        {
            try
            {
                File.Delete(targetPath);
            }
            catch (Exception)
            {
                throw new Exception("Unable to clear failed temporary file.");
            }
        }
    }

    private static bool IsWord(string context, string word)
    {
        word = word.Trim();
        int wordIndex = context.IndexOf(word);

        char? beforeChar = null;
        char? afterChar = null;
        if (wordIndex > 0)
        {
            beforeChar = context[wordIndex - 1];
        }

        if (wordIndex + word.Length < context.Length)
        {
            afterChar = context[wordIndex + word.Length];
        }

        bool isWord = (beforeChar == null || char.IsPunctuation((char)beforeChar) || beforeChar == ' ')
                      && (afterChar == null || char.IsPunctuation((char)afterChar) || afterChar == ' ');

        return isWord;
    }
}
