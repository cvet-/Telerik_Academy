// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;

class Workdays
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Enter day in format yyyy/mm/dd:");
        string[] dateStr = Console.ReadLine().Split('/');
        int year = Int32.Parse(dateStr[0]);
        int days = Int32.Parse(dateStr[2]);
        int month = Int32.Parse(dateStr[1]);
        DateTime endDate = new DateTime(year, month, days);

        Console.WriteLine(GetWorkDays(currentDate,endDate));
    }

    static DateTime[] holidays = {new DateTime(2015, 03, 03), new DateTime(2015, 04, 10), new DateTime(2015, 04, 11), 
                                  new DateTime(2015, 04, 12), new DateTime(2015, 04, 13), new DateTime(2015, 12, 24), 
                                  new DateTime(2015, 12, 25), new DateTime(2015, 12, 30),new DateTime(2015, 12, 31), 
                                  new DateTime(2016, 01, 01)};

    static int FilterHolidays(DateTime start, DateTime end, int result)
    {
        foreach (DateTime holiday in holidays)
            if (start <= holiday && holiday <= end &&
                !(holiday.DayOfWeek == DayOfWeek.Saturday || holiday.DayOfWeek == DayOfWeek.Sunday))
                result--;

        return result;
    }

    static void TrimPeriod(ref DateTime start, ref DateTime end)
    {

        if (start.DayOfWeek == DayOfWeek.Saturday) start = start.AddDays(2);
        if (start.DayOfWeek == DayOfWeek.Sunday) start = start.AddDays(1);


        if (end.DayOfWeek == DayOfWeek.Saturday) end = end.AddDays(-1);
        if (end.DayOfWeek == DayOfWeek.Sunday) end = end.AddDays(-2);
    }

    static int GetWorkDays(DateTime start, DateTime end)
    {
        if (end < start) return GetWorkDays(end, start);

        TrimPeriod(ref start, ref end);

        int offset = (int)(end - start).TotalDays + 1;

        int result = offset / 7 * 5 + offset % 7;

        return FilterHolidays(start, end, Math.Max(result, 0));
    }

}


