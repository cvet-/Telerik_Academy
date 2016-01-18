/* Problem 11: Write a program that reads two positive integer numbers
 and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. */

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Beginning of interval: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("End of interval: ");
        int m = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = n; i <= m; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("The # of numbers with reminder 0 of division by 5 is: {0}", count);

    }
}

