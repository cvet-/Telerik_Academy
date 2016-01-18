using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birthday:");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Today;
        
        int age = 0;
        if (today.Month < birthday.Month)
        {
            age = today.Year - birthday.Year - 1;
        }
        else if (today.Month > birthday.Month)
        {
            age = today.Year - birthday.Year;
        }
        else
        {
            if (today.Day < birthday.Day)
            {
                age = today.Year - birthday.Year - 1;
            }
            else
            {
                age = today.Year - birthday.Year;
            }
        }
        Console.WriteLine("After 10 years you will be {0} years old!", age+10);        
    }
}