/* Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements. */

using System;

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (b >= c)
                Console.WriteLine("The sorted numbers: {0} {1} {2}", a, b, c);

            else if (c >= a) Console.WriteLine("The sorted numbers: {0} {1} {2}", c, a, b);

            else Console.WriteLine("The sorted numbers: {0} {1} {2}", a, c, b);
        }
        else if (b >= a)
        {
            if (a >= c) Console.WriteLine("The sorted numbers: {0} {1} {2}", b, a, c);

            else if (c >= b) Console.WriteLine("The sorted numbers: {0} {1} {2}", c, b, a);

            else Console.WriteLine("The sorted numbers: {0} {1} {2})", b, c, a);
        }

    }


}



