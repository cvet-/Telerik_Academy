/* Write an expression that checks if given positive integer number n (n = 100)
 is prime (i.e. it is divisible without remainder only to itself and 1). */

using System;


/* Problem 8: Write an expression that checks if given positive integer number n (n <= 100) is prime
 (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive */

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int i;
        if (number < 0) Console.WriteLine("The number is not prime!");
        
        for (i = 2; i <= number - 1; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("The number is not prime!");
                return;
            }
        }
        if (i == number)
        {
            Console.WriteLine("The number is prime!");
        }


    }
}

