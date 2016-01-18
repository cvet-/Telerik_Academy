// Write a program that replaces in a HTML document given as string all the tags
// <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string line = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href	= \"www.devbg.org\">our forum</	a > to discuss the courses.</p>";
        string replaced = line.Replace(@"<a href=""", "[URL=");
        
        replaced = replaced.Replace(@""">", "]");
        replaced = replaced.Replace("</a>", "/URL]");

        Console.WriteLine(replaced);
    }
}

