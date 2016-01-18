//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static T FindMin<T>(params T[] numbers) where T : IComparable<T>
    {
        int minIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[minIndex]) == -1) minIndex = i;
        }
        return numbers[minIndex];
    }

    static T FindMax<T>(params T[] numbers) where T : IComparable<T>
    {
        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;
        }
        return numbers[maxIndex];
    }

    static T FindSum<T>(params T[] numbers) where T : IComparable<T>
    {
        return numbers.Aggregate<T, dynamic>(0, (current, t) => current + t);
    }

    static float FindAverageSum<T>(params T[] numbers) where T : IComparable<T>
    {
        dynamic averageSum = numbers.Aggregate<T, dynamic>(0, (current, t) => current + t);
        return averageSum / numbers.Length;
    }

    static T FindProduct<T>(params T[] numbers) where T : IComparable<T>
    {
        return numbers.Aggregate<T, dynamic>(1, (current, t) => current * t);
    }

    static void Main()
    {
        Console.WriteLine("Min: {0}", FindMin(5, 1, 2, 3, 4, 26, 17));
        Console.WriteLine("Max: {0}", FindMax(5.2, 1, 2, 3, 4, 2.6, 1.7, 1000.53));
        Console.WriteLine("Average sum: {0}", FindAverageSum(5, 1, 2, 3, 4, 26, 17));
        Console.WriteLine("Sum: {0}", FindSum(5, 1, 2, 3, 4, 26, 17));
        Console.WriteLine("Product: {0}\n", FindProduct(5.2, 1, 2, 3, 4, 2.6, 1.7));
    }
}