/* Problem 6: Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. */

using System;
using System.Linq;

class FourDigit
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a four-digit number: ");
        int[] num = Console.ReadLine()
                .Trim()
                .ToCharArray()
                .Select(x => Int32.Parse(x.ToString()))
                .ToArray();

        if (num[0] == 0)
        {
            Console.WriteLine("The number can't start with 0!");
            return;
        }
        Console.Clear();

        Console.WriteLine("The sum of the digits is {0}:\nReversed number: {1}", DigitsSum(num), ReversedDigits(num));
        Console.WriteLine("Last digit in front: {0}", SwapFirstAndLast(num));
        Console.WriteLine("SwapSecondAndThird: {0}", SwapSecondAndThird(num));
    }

    /// <summary>
    /// This function finds the sum of the 4 digits
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    static int DigitsSum(int[] num)
    {
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        return sum;
    }
    /// <summary>
    /// This function finds the reversed number
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    static string ReversedDigits(int[] num)
    {
        string reversedDigits = string.Join("", num.Reverse());
        return reversedDigits;
    }
    /// <summary>
    /// This function puts the last digit in the first position
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    static string SwapFirstAndLast(int[] num)
    {
        string lastDigitFirst = "" + num[num.Length - 1];
        for (int i = 0; i < num.Length - 1; i++)
        {
            lastDigitFirst += num[i];
        }

        return lastDigitFirst;

    }
    /// <summary>
    /// This function exchanges the second and the third digits:
    /// </summary>
    /// <param name="digits"></param>
    /// <returns></returns>
    static string SwapSecondAndThird(int[] digits)
    {
        return digits[0].ToString() + digits[2] + digits[1] + digits[3];
    }

}

