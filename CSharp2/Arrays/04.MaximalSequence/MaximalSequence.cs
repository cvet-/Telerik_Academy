/* Write a program that finds the maximal sequence of equal elements in an array. */

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        // Array Declaration
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter array: ");
        int[] arr = new int[length];

        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
       
        var sequence = GetSequence(arr);
        Console.WriteLine(string.Join(", ",sequence));
    }
    /// <summary>
    /// Finds the maximal sequence of equal elements
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static int[] GetSequence(int[] array)
    {
        int bestInt = array[0];
        int maxLength = 0;
        int tempLength = 1;
        int lastInt = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != lastInt)
            {
                tempLength = 1;
                lastInt = array[i];
            }
            else
            {
                tempLength++;
            }

            if (tempLength > maxLength)
            {
                maxLength = tempLength;
                bestInt = array[i];
            }
        }
        return Enumerable.Range(0, maxLength).Select(x => bestInt).ToArray();
    }
}