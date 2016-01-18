//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>


using System;
using System.IO;

class Extract
{
    static void Main()
    {
        const string sourcePath = @"../../File.txt";
        RemoveFileXMLCode(sourcePath);
    }

    private static void RemoveFileXMLCode(string sourcePath)
    {
        string content = null;
        try
        {
            content = File.ReadAllText(sourcePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (content == null)
        {
            return;
        }

        int openBracketIndex;
        int closingBracketIndex;
        do
        {
            openBracketIndex = content.IndexOf("<");
            closingBracketIndex = content.IndexOf(">");
            if (openBracketIndex >= 0 || closingBracketIndex >= 0)
            {
                if (openBracketIndex < closingBracketIndex)
                {
                    content = content.Remove(openBracketIndex, closingBracketIndex - openBracketIndex + 1);
                }
            }
        } while (openBracketIndex > 0 || closingBracketIndex > 0);

        try
        {
            File.WriteAllText(sourcePath, content);
        }
        catch (Exception ex)
        {
            throw new Exception("Unable to write to the file.", ex.InnerException);
        }
    }
}

