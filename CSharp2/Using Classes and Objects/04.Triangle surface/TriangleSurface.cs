// Write methods that calculate the surface of a triangle by given:
// Side and an altitude to it;
// Three sides;
// Two sides and an angle between them;
// Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculating area of a triangle:\n");
        Console.WriteLine(
@"By side and altitude - Press 1.
By three sides - Press 2.
By two sides and an angle between them - Press 3");

        int choiceMethod = int.Parse(Console.ReadLine());

        switch (choiceMethod)
        {
            case 1: AreaBySideAndAltitude();
                break;
            case 2: AreaByThreeSides();
                break;
            case 3: AreaByTwoSidesAndAngle();
                break;
            default: Console.WriteLine("Error! Enter correct number!");
                break;
        }
    }

    private static void AreaBySideAndAltitude()
    {
        Console.WriteLine("Enter a side: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter an altitude: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("S = {0}", a * h / 2);
    }

    private static void AreaByThreeSides()
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double p = (a + b + c) / 2;
        Console.WriteLine("S = {0}", Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
    }

    private static void AreaByTwoSidesAndAngle()
    {
        Console.WriteLine("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the angle between a and b: ");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("S = {0}", a * b * Math.Sin(Math.PI * angle / 180) / 2);
    }
}

