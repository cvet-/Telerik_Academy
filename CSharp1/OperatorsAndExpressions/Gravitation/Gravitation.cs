/* Problem 2: The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. */

using System;

class Gravitation
{
    static void Main()
    {
        const double moonGravity = 0.17; // Declaring the gravitation field as a constant variable.
        
        Console.WriteLine("What's your weight?");
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight*moonGravity;
        
        Console.WriteLine("Your weight on the moon is: {0}", moonWeight);

    }
}

