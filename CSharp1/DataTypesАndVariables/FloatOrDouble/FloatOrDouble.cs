/* Problem 2: Which of the following values can be assigned to a variable of type float 
 and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost. */

using System;

class FloatOrDouble
{
    static void Main()
    {
        // Asigning the variables to the proper type
        float aFloat = 12.345f;
        float aFloatAgain = 3456.091f;
        double aDouble = 34.567839023;
        double aDoubleAgain = 892312.1234857;
        
        // Printing the variables
        Console.WriteLine("Floats: {0} and {1}\nDoubles: {2} and {3}",
            aFloat, aFloatAgain, aDouble, aDoubleAgain);
    }
}



