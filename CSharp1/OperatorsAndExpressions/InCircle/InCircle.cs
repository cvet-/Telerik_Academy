/* Problem 7: Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). */
using System;

class InCircle
{
    static void Main()
    {
        Console.Write("Enter the X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter the Y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        const int r = 2;

        if (Math.Pow(x,2) + Math.Pow(y,2) < r*r)
        {
            Console.WriteLine("The point with coordinates ({0},{1}) IS WITHIN the circle with radius {2}!", x,y,r);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0},{1}) IS OUTSIDE the circle with radius {2}!", x,y,r);
        }
    }
}

