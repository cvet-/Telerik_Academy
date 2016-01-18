using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        string format = "d.M.yyyy";
        CultureInfo culture = CultureInfo.InvariantCulture;
        Console.Write("Enter first year in format day.month.year: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, culture);

        Console.Write("Enter second year in format day.month.year: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, culture);

        if (firstDate <= secondDate)
        {
            Console.WriteLine("Total days in betwee: {0}", (secondDate - firstDate).TotalDays);
        }
        else
        {
            Console.WriteLine("First is later in time than second date.");
        }

    }
}
