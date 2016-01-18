/* Problem 7: Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined. */ 

using System;

class QuotesInString
{
    static void Main()
    {
        string doubleQuote = @"The ""use"" of quotations causes difficulties!";  // Using quoted string
        string escape = "The \"use\" of quotations causes difficulties!";       // Using escaping 
        
        Console.WriteLine(doubleQuote);
        Console.WriteLine(escape);
    }
}

