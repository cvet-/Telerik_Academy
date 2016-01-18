/* Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. */

using System;
using System.Collections.Generic;
using System.Linq;
class NumbersInRandomPosition
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool increment = num >= 1;
        List<int> numbers = GetNumbers(num, increment);
        Random random = new Random();

        var result = numbers.OrderBy(item => random.Next());

        Console.WriteLine(string.Join(", ", result));
    }

    private static List<int> GetNumbers(int num, bool increment)
    {
        List<int> numbers = new List<int>();
        if (num == 0)
        {
            numbers.Add(1);
            numbers.Add(0);
        }
        else
        {
            for (int i = 1; Math.Abs(i) <= Math.Abs(num); )
            {
                numbers.Add(i);
                if (increment) ++i;
                else --i;
            }
        }
        return numbers;
    }
}
