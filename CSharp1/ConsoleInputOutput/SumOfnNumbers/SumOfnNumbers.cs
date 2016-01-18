/* Problem 9: Write a program that enters a number n 
 and after that enters more n numbers and calculates and prints their sum. */

using System;

class SumOfnNumbers
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sum: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter numbers: ");
        double[] numbers = new double[400];     // Declaration of array
        for (int i = 0; i < n; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());     // Input the numbers of array
        }
        
        double sum = 0;    

        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];      // Finding the sum of all the members of the array
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}

