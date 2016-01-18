//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;

class TheBiggestOf3Numbers
{
    static void Main()
    {              
        Console.Write("Enter the first number: ");
        double firstNum = Double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNum = Double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double thirdNum = Double.Parse(Console.ReadLine());
        double biggestNum = 0;

        biggestNum = firstNum >= secondNum ? firstNum : secondNum;
        biggestNum = biggestNum >= thirdNum ? biggestNum : thirdNum;

        Console.WriteLine("The biggest of three numbers is: {0}", biggestNum);

    }
}

