/* Problem 5: Write an expression that checks for given integer if its third digit from right-to-left is 7. */

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if ((num / 100) % 10 == 7) 
        {
            Console.WriteLine("The 3rd digit of the number you entered is 7");
        }
        else
        {
            int digit = ((num / 100) % 10);
            Console.WriteLine("The 3rd digit of the number you entered ISN'T 7. It's: {0}", digit);
        }

    }
}