// Write a program that parses an URL address given in the format: 
// [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        const string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        const string urlExpressions = "(.*)://(.*?)(/.*)";

        GroupCollection groups = Regex.Match(url, urlExpressions).Groups;
        Console.WriteLine("[protocol] = {0}", groups[1]);
        Console.WriteLine("[server] = {0}", groups[2]);
        Console.WriteLine("[resource] = {0}", groups[3]);
    }
}
