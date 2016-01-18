/* Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality. */

using System;
class program
{
    public static void Main()
    {
        int decimalNumber, quotient;
        int i = 1, j, temp = 0;
        char[] hexadecimalNumber = new char[100];
        char temp1;
        Console.WriteLine("Enter a Decimal Number :");
        decimalNumber = int.Parse(Console.ReadLine());
        quotient = decimalNumber;
        while (quotient != 0)
        {
            temp = quotient % 16;
            if (temp < 10)
                temp = temp + 48;
            else
                temp = temp + 55;
            temp1 = Convert.ToChar(temp);
            hexadecimalNumber[i++] = temp1;
            quotient = quotient / 16;
        }
        Console.Write("Equivalent HexaDecimal Number is ");
        for (j = i - 1; j > 0; j--)
            Console.Write(hexadecimalNumber[j]);
        Console.Read();

    }
}