/* Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
 the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below. */

using System;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {        
        int n = int.Parse(Console.ReadLine());
        int[] num = Enumerable.Range(0, n)
                .Select(x => int.Parse(Console.ReadLine()))
                .ToArray();

        int min = num.Min();
        int max = num.Max();
        int sum = num.Sum();
        double average = (double)sum / n;
        Console.WriteLine(@"
min = {0}
max = {1}
sum = {2}
average = {3:F2}
", min,max,sum,average);

    }
}

