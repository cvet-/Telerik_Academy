/* Problem 3: Write a program that reads the radius r of a circle and prints its perimeter and area
 formatted with 2 digits after the decimal point.*/

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius * radius;  // Formula for calculating the area of a circle
        double perimeter = Math.PI * 2 * radius; // Formula for calculating the perimeter of a circle
       
        Console.Clear();
        Console.WriteLine("Area: {0}\nPerimeter: {1}", Math.Round(area, 2), Math.Round(perimeter, 2));
    }
}

