/* Problem 4: Declare a character variable and assign it with the symbol that has
  Unicode code 42 (decimal) using the \u00XX syntax, and then print it.*/
 
using System;

class Program
{
    static void Main(string[] args)
    {
        char character = '\u002A';
        Console.WriteLine((character == '*') ? true : false); // Checks if the symbol is * if so the output is true, if not the output is false
        Console.WriteLine(character); // Prints the symbol on the screen
    }
}

