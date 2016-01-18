//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. 
//inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9

using System;

class SubStringInText
{
    static void Main()
    {
        const string text =
@"We are living in an yellow submarine. We don't have anything else. 
inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine(SubstringCount(text, "in"));
    }
    private static int SubstringCount(string text, string substring)
    {
        int count = 0;
        int subIndex;
        do
        {
            subIndex = text.IndexOf(substring, StringComparison.InvariantCultureIgnoreCase);
            if (subIndex > 0)
            {
                text = text.Remove(subIndex, substring.Length);
                count++;
            }
        } while (subIndex>= 0);
       
        return count;
    }
}

