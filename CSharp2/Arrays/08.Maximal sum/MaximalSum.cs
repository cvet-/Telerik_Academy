/* Write a program that finds the sequence of maximal sum in given array. */

using System;

class MaximalSum
{
    static void Main()
    {

        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]] = ", i);

            array[i] = int.Parse(Console.ReadLine());
        }
       
        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempStartIndex = 0;
        int maxSum = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                tempStartIndex = i;
            }
            else
            {
                currentSum += array[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;

                startIndex = tempStartIndex;
                endIndex = i;
            }
        }

        Console.WriteLine("The sum is: {0} ", maxSum);
        Console.WriteLine();
        Console.WriteLine("The sequence is:");

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

