//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;
class SortingArray
{
    /// <summary>
    /// Finds the max element
    /// </summary>
    /// <param name="array"></param>
    /// <param name="givenIndex"></param>
    /// <returns></returns>
    static int MaxElement(int[] array, int givenIndex)
    {
        int biggestIndex = givenIndex;

        for (int i = givenIndex; i < array.Length; i++)
        {
            if (array[givenIndex] < array[i])
            {
                biggestIndex = i;
            }
        }

        return array[biggestIndex];
    }
    /// <summary>
    /// Sorts array in ascending order
    /// </summary>
    /// <param name="array"></param>
    static void SortArrayAscending(int[] array) 
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;

            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[min])
                {
                    min = p;
                }
            }

            if (min != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
    }
    /// <summary>
    /// Sorts array in descending order
    /// </summary>
    /// <param name="array"></param>
    static void SortArrayDescending(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int p = i + 1; p < array.Length; p++)
            {
                if (array[p] < array[min])
                {
                    min = p;
                }
            }
            if (min != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        Array.Reverse(array);
    }
    /// <summary>
    /// Output array
    /// </summary>
    /// <param name="array"></param>
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {

        Console.Write("Enter numbers separated by comma: ");
        int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

        Console.Write("Enter start position: ");
        int givenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Maximal element in this array portion is: {0}", MaxElement(array, givenIndex));
        Console.WriteLine();
        Console.WriteLine(
@"Sort the array:
For ascending order press 1 
For descending order press 2");

        int howToSort = int.Parse(Console.ReadLine());

        if (howToSort == 1)
        {
            SortArrayAscending(array);
            PrintArray(array);
        }

        if (howToSort == 2)
        {
            SortArrayDescending(array);
            PrintArray(array);
        }

        else if (howToSort != 1 && howToSort != 2)
        {
            Console.WriteLine("Error! Try Again!");
        }
    }
}
