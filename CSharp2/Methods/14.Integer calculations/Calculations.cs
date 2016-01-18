//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Calculations
{
    // Using LINQ to make life easier

    static int FindMax(params int[] array)
    {
         return array.Max();
    }

    static int FindMin(params int[] array)
    {
        return array.Min();
    }

    static double GetAverage(params int[] array)
    {
        return array.Average();
    }
    static int GetSum(int[] array)
    {

        return array.Sum();
    }

    static int FindProduct(params int[] array)
    {
       return array.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter numbers separated by comma: ");
        int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        Console.WriteLine();
        Console.WriteLine("Min: {0}", FindMin(array));
        Console.WriteLine("Max: {0}", FindMax(array));
        Console.WriteLine("Sum: {0}", GetSum(array));
        Console.WriteLine("Average: {0}", GetAverage(array));
        Console.WriteLine("Product: {0}", FindProduct(array));
    }
}

