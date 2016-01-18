/* Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet). */

using System;

public class Program
{
    static int GCD(int a, int b)
    {
        int Remainder;
    
        while( b != 0 )
        {
            Remainder = a % b;
            a = b;
            b = Remainder;
        }
      
        return a;
    }

    static int Main(string[] args)
    {
        int x, y;
      
        Console.WriteLine("This program allows calculating the GCD");
        Console.Write("Value 1: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Value 2: ");
        y = int.Parse(Console.ReadLine());

        Console.Write("\nThe Greatest Common Divisor of ");
        Console.WriteLine("{0} and {1} is {2}", x, y, GCD(x, y));
 
        return 0;
    }
}