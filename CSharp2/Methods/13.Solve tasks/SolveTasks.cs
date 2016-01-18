//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
class SolveTasks
{
    public static int ReverseNumber(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }

    static double GetAverage(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];            
        }
        return (double)sum / array.Length;
    }

    static double SolveEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void PrintReverseDigits()
    {
        Console.WriteLine("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            Console.WriteLine("Reversed: " + ReverseNumber(n));
        }
        else
        {
            Console.WriteLine("The number should be positive");
        }
    }

    static void PrintAverage()
    {
        Console.WriteLine("The the length of the array: ");
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        if (array.Length > 0)
        {
            Console.WriteLine("Get Average: " + GetAverage(array));
        }
        else
        {
            Console.WriteLine("You have entered blank or invalid input!");
        }
    }

    static void PrintEquation()
    {
        Console.WriteLine("Enter a and b");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine("Solve equation" + SolveEquation(a, b));
        }
        else
        {
            Console.WriteLine("Coefficient 'a' cannot be zero!");
        }

    }
    static void Main()
    {
        Console.WriteLine(
@"1: ReverseDigits 
2: GetAverage 
3: SolveEquation");

        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            PrintReverseDigits();
        }
        else if (n == 2)
        {
            PrintAverage();
        }
        else if (n == 3)
        {
            PrintEquation();
        }
    }
}
