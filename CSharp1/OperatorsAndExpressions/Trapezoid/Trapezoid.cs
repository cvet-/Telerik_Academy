/*Problem 9: Write an expression that calculates trapezoid's area by given sides a and b and height h */

using System;

class Trapezoid          // ((a+b)/2)*h
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine ());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;
        Console.Write("Area: {0}", area);

        Console.WriteLine();
    }
}

