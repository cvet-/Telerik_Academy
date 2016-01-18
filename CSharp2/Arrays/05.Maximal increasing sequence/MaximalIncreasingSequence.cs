/* Write a program that finds the maximal increasing sequence in an array. */

using System;

class MaximalIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int sequence = 1;
        int maxSeq = 0;
        string sequenceNums = "";
        string maxSequenceNums = "";
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                sequence++;
                sequenceNums += array[i] + " ";
            }
            else
            {
                if (maxSeq < sequence)
                {
                    maxSeq = sequence;
                    sequenceNums += array[i] + " ";
                    maxSequenceNums = sequenceNums;
                }
                sequence = 1;
                sequenceNums = "";
            }
        }

        if (maxSeq < sequence)
        {
            sequenceNums += array[array.Length - 1];
            maxSequenceNums = sequenceNums;
        }

        Console.WriteLine("The maximal increasing sequence in an array is: ");
        Console.WriteLine(maxSequenceNums);
    }
}

