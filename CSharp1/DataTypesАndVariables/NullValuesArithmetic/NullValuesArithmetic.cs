/* Problem 12: Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result. */

using System;

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        // Assigning null values to an integer and a double using nullable int and double
        int? nullInt = null;
        double? nullDouble = null;
        Console.WriteLine("Nullable Int: {0}, Nullable Double: {1}, ", nullInt, nullDouble);
        
        // Initializing
        nullInt = 935;
        nullDouble = 12.667;
        Console.WriteLine("Nullable Int(with assigned value): {0}, Nullable Double(with assigned value): {1}", nullInt, nullDouble);
    }
}

