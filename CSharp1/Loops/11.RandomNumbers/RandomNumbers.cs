/* Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max]. */

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Please enter integer n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter min integer: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter max integer: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();

        for (int i = 0; i <= n; i++)
        {
            int random = rnd.Next(min, max + 1);
            Console.WriteLine(random);
        }
        Console.WriteLine();
    }
}
