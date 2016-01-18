// Exemplary output

using System;
using System.Text;

namespace TaskManager
{
    class Solve
    {
        static void Main(string[] args)
        {
            // Problem 1: Write a program to convert decimal numbers to their binary representation.
            Console.WriteLine(Converter.DecimalToBinary(5));
            Console.WriteLine();

            // Problem 2: Write a program to convert binary numbers to their decimal representation.
            Console.WriteLine(Converter.BinaryToDecimal("11100110"));
            Console.WriteLine();

            // Problem 3: Write a program to convert decimal numbers to their hexadecimal representation.
            Console.WriteLine(Converter.DecimalToHex(12262011));
            Console.WriteLine();

            // Problem 4: Write a program to convert hexadecimal numbers to their decimal representation. 
            Console.WriteLine(Converter.HexToDecimal("BB1A7B"));
            Console.WriteLine();

            // Problem 5: Write a program to convert hexadecimal numbers to binary numbers (directly).
            Console.WriteLine(Converter.HexToBinary("BB1A7B"));
            Console.WriteLine();

            // Problem 6: Write a program to convert binary numbers to hexadecimal numbers (directly).
            Console.WriteLine(Converter.BinaryToHex("11010110"));
            Console.WriteLine();

            // Problem 7: Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
            Console.WriteLine(Converter.FromAnyToAny("263", 10, 5));
            Console.WriteLine(Converter.FromAnyToAny("BB1A7B", 16, 5));
            Console.WriteLine(Converter.FromAnyToAny("BB1A7B", 16, 8));
            Console.WriteLine();
            // Problem 8: Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
            Console.WriteLine(Converter.BinaryShort(250));

            Console.WriteLine();

            //Problem 9: Write a program that shows the internal binary representation of given 32-bit signed floating-point number 
            //in IEEE 754 format (the C# type float).
            string[] result = Converter.FloatingPoint(-27.25f);
            Console.WriteLine("Sign:     " + result[0]);
            Console.WriteLine("Exponent: " + result[1]);
            Console.WriteLine("Mantissa: " + result[2]);
        }
    }
}
