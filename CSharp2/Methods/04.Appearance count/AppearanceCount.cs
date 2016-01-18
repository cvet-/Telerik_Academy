//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static int Counter(int[] numbers, int searchedNumber)
    {
        return numbers.Count(x => x == searchedNumber);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter numbers separated by comma: ");
        int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        Console.Write("Enter the searched number: ");
        int searchedNumber = int.Parse(Console.ReadLine());
        int count = Counter(numbers, searchedNumber);
        
        Console.WriteLine("{0} appears {1} times",searchedNumber,count);
    }
}

