/* Problem 3: Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254. */

using System;

class VariableInHex
{
    static void Main()
    {
        int hex = 0xFE; // The hexadecimal representation of 254 is 0xFE
        Console.WriteLine("The decimal value of 0xFE is {0}", hex);
    }
}