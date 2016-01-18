//Write a method that reverses the digits of given decimal number.

using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed: {0}", Reverse(number));
    }

    public static int Reverse(int num)
    {

        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
}
