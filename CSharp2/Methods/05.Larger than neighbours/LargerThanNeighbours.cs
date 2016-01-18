//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the array");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array[{0}] = ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the postion of element in the array to check: ");
        int position = int.Parse(Console.ReadLine());

        CompareToNeighbour(n, numbers, position);
    }

    static void CompareToNeighbour(int n, int[] numbers, int position)
    {
        if (position == 0 || position == numbers.Length - 1)
        {
            Console.WriteLine("The number has only one neightbour!");
        }
        else if (numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
        {
            Console.WriteLine("The number is larger than its two neighbours!");
        }
        else if (numbers[position] < numbers[position - 1] && numbers[position] < numbers[position + 1])
        {
            Console.WriteLine("The number is smaller than its two neighbours");
        }
        else
        {
            Console.WriteLine("The number is equal to its neightbours");
        }
    }
}

