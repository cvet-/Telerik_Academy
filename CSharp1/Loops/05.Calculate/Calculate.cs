/* Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point. */

using System;

class TheSumOfSequence
{
    static void Main()
    {
        checked
        {
            Console.Write("Enter N = ");
            string inputStr = Console.ReadLine();
            int numN = int.Parse(inputStr);
            Console.Write("Enter X = ");
            inputStr = Console.ReadLine();
            int numX = int.Parse(inputStr);
            if (numN < 1)
            {
                Console.WriteLine("Invalid Number");
            }
            else
            {
                
                double factorialN = 1;
                double numXPowerN = 1;
                double sumOfSequence = 1;
                for (int i = 1; i <= numN; i++)
                {
                    factorialN *= i;
                    numXPowerN *= numX;
                    sumOfSequence += (factorialN / numXPowerN);
                }
                Console.WriteLine("Sum = {0:F5}",
                    sumOfSequence);
            }
            Console.ReadLine();
        }
    }
}