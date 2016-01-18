/* Problem 4: Write an expression that calculates rectangle’s perimeter and area by given width and height. */

using System;

class Rectangles
    {
        static void Main()
        {
            Console.Write("The width of the rectangle is: ");
            double width = double.Parse (Console.ReadLine());
            Console.Write("The height of the rectangle is: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The parameter of the rectangle is {0}!\nThe area of the rectangle is {1}!",
                width * 2 + height * 2, width * height);

        }
    }

