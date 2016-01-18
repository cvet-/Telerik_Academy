/* Problem 10: Write a program that reads a number n and prints on the console the first n members 
 of the Fibonacci sequence (at a single line, separated by comma and space - ,):
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …*/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        long last = 1;
        long beforeLast = 0;
        long current = beforeLast + last;
        
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(beforeLast);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
            beforeLast = last;
            last = current;
            current = beforeLast + last;
        }
        Console.WriteLine();
    }
}

