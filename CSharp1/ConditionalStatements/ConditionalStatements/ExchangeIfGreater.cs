/* Problem 1: Write an if-statement that takes two double variables a and b and exchanges their values 
 if the first one is greater than the second one. As a result print the values a and b, separated by a space. */
using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        double swap;
        if(a>b) // if statement to check for the condition
        {
            // Exchange the values of the given variables
            swap = a;
            a = b;
            b = swap;
            Console.WriteLine("{0} {1}",a,b); // Prints the numbers with exchanged positions 
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b); // Prints the numbers as they are entered

        }
    }
}
