// Problem 3: Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
using System;

class DivideBy
{
    static void Main()
    {
        Console.WriteLine("Number:");
        int number = int.Parse(Console.ReadLine());

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            Console.WriteLine("True!");
        }
        else
        {
            Console.WriteLine("False!");
        }
    }
}


