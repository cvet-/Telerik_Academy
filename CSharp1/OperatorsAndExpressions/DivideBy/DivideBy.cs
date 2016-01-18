/* Problem 3: Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time. */
using System;

class DivideBy
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} divisible by 7 and 5!", isDivisible(num) ? "Is" : "isn't");

    }
    static bool isDivisible(int num)
    {
        if (num % 35 != 0) return false;
        return true;
    }

}

