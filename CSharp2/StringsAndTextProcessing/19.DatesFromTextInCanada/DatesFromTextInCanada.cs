// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

class DatesFromTextInCanada
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = "2015.02.15 02.15.2015 2.15.2015 2.15.2015";

        string format = "dd.mm.yyyy";
        CultureInfo culture = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), format, culture);
                Console.WriteLine(check.ToShortDateString());
            }
            catch(FormatException)
            {
                continue;
            }
           
        }
    }
}

