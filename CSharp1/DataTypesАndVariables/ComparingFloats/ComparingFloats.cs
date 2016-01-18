// Problem 13: Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter number a: ");
        var firstNum = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        var secondNum = decimal.Parse(Console.ReadLine());

        // Checks if the difference between the numbers equals eps, if so they are considered different
        if (((secondNum - firstNum) == 0.000001m) || (firstNum - secondNum) == 0.000001m)
        {
            Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
        }
        // Check if the two numbers are equal with opposite signs
        else if ((firstNum * -1) == (secondNum) || (firstNum == (secondNum * -1)) || (float)firstNum == (float)secondNum)
        {
            Console.WriteLine("The result is:  {0} The difference {1} < eps", true, (firstNum - secondNum) * -1);
        }
        // If the above condition is not true 
        else
        {
            Console.WriteLine("The result is:  {0} The difference of {1} is too big (> eps)", false, secondNum - firstNum);
        }
    }
}

