// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

using System;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string text = "<html><head><title>News</title></ head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";

        StringBuilder result = new StringBuilder();

        bool openTag = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                openTag = true;
            }

            if (!openTag)
            {
                result.Append(text[i]);

                if (text[i + 1] == '<')
                {
                    result.AppendLine();
                }
            }

            if (text[i] == '>')
            {
                openTag = false;
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}
