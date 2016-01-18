/* Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality. */

using System;

class Program
{
    static void Main(string[] args)
    {
        string binary = Console.ReadLine().Trim();    // my binary "number" as a string
        var dec = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            // we start with the least significant digit, and work our way to the left
            if (binary[binary.Length - i - 1] == '0') continue;
            dec += (int)Math.Pow(2, i);
        }
        Console.WriteLine(dec);
    }
}

