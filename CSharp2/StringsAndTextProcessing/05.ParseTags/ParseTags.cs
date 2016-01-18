//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Security;

class ParseTags
{
    static void Main()
    {

        const string text = "We are living in a <upcase>yellow submarine</upcase>." +
                               " We don't have <upcase>anything</upcase> else.";

        string uppercased = GetUppercasedByTags(text);
        Console.WriteLine(uppercased);
    }
    private static string GetUppercasedByTags(string text)
    {
        const string openTag = "<upcase>";
        const string closeTag = "</upcase>";

        int openTagsCount = GetSubstringCount(text, openTag);
        int closeTagsCount = GetSubstringCount(text, closeTag);
        if (openTagsCount != closeTagsCount)
        {
            // The exception that is thrown when there is a syntax error in XML parsing. 
            throw new XmlSyntaxException("Some open or close tags are missing."); 
        }

        if (openTagsCount < 1)
        {
            return text;
        }

        int currentOpenTagIndex;
        int currentCloseTagIndex;
        do
        {
            currentOpenTagIndex = text.IndexOf(openTag, StringComparison.OrdinalIgnoreCase);
            if (currentOpenTagIndex < 0)
            {
                break;
            }

            text = text.Remove(currentOpenTagIndex, openTag.Length);

            currentCloseTagIndex = text.IndexOf(closeTag, StringComparison.OrdinalIgnoreCase);
            if (currentCloseTagIndex < 0)
            {
                break;
            }

            text = text.Remove(currentCloseTagIndex, closeTag.Length);

            string upperText = text.Substring(currentOpenTagIndex, currentCloseTagIndex - currentOpenTagIndex).ToUpper();
            text = text.Remove(currentOpenTagIndex, currentCloseTagIndex - currentOpenTagIndex);
            text = text.Insert(currentOpenTagIndex, upperText);
        } while (currentOpenTagIndex > 0 && currentCloseTagIndex > 0);

        return text;
    }

    private static int GetSubstringCount(string text, string substring)
    {
        int subCount = 0;
        int subIndex;
        do
        {
            subIndex = text.IndexOf(substring, StringComparison.InvariantCultureIgnoreCase);
            if (subIndex > 0)
            {
                text = text.Remove(subIndex, substring.Length);
                subCount++;
            }
        } while (subIndex >= 0);

        return subCount;
    }
}

