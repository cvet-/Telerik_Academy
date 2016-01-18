﻿//Problem 8. Write a program that prints an isosceles triangle of 9 copyright symbols ©

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        const int symbolsCount = 9; // The width of the triangle
        char symbol = '\u00a9';
        string innerSpace;       // Variable that holds the space inside the triangle of c symbols 
        string outerSpace = new String(' ', (symbolsCount - 1) / 2);   // (9 spaces - 1 symbol c) divide by 2 to find the apex of the triangle, the point from where our triangle starts
        Console.WriteLine(outerSpace + symbol + outerSpace);  // Print the first line  
        for (int i = 0, j = 3; j > 0; i++, j--)      // Create for loop 
        {
            outerSpace = new String(' ', j);     // Changing the value of outerSpace - the space outside the triangle
            innerSpace = new String(' ', i * 2 + 1);  // Changing the value of innerSpaces - the space inside the triangle

            Console.WriteLine(outerSpace + symbol + innerSpace + symbol); // Prints the triangle, the symbols and the spaces inside and out of it
        }

        for (int i = 0; i < symbolsCount; i++)
        {
            if (i % 2 == 1) Console.Write(' '); // If the counter is on even position prints space
            else Console.Write(symbol);         // If it's on odd position prints the symbol
        }

        Console.WriteLine();
    }
}
