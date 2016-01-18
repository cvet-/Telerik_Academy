/* Problem 10: Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
 and out of the rectangle R(top=1, left=-1, width=6, height=2). */

using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter X coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        const double r = 1.5;
       
        if ((Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) < Math.Pow(r, 2)) && ((x < -1) || (x > 5) || (y < -1) || (y > 1)))
        {
            Console.WriteLine("The point with coordinates ({0};{1}) is withing the circle and out of the rectangle", x, y);

        }
        else
        {
            Console.WriteLine("The point with coordinates ({0};{1}) is NOT withing the circle and out of the rectangle",x,y);
        }
    }

}

