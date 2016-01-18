/* Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. */

/* Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators. */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Write the first number: ");
        double firstNum = Double.Parse(Console.ReadLine());
        Console.Write("Write the second number: ");
        double secondNum = Double.Parse(Console.ReadLine());
        Console.Write("Write the third number: ");
        double thirdNum = Double.Parse(Console.ReadLine());
        sbyte count = 0;
        string sign = "";

        if (firstNum < 0)
        {
            count++;
        }

        if (secondNum < 0)
        {
            count++;
        }

        if (thirdNum < 0)
        {
            count++;
        }

        if (count % 2 != 0)
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            sign = "0";
        }

        Console.WriteLine(sign);
    }

}

