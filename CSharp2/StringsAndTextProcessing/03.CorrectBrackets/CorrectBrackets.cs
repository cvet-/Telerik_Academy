//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class CorrectBrackets
{
    static void Main()
    {
        string equation = "((a+b)/5-d)";
        Console.WriteLine(BracketsCheck(equation));

        string secondEquation = ")(a+b))";
        Console.WriteLine(BracketsCheck(secondEquation));
    }
    private static bool BracketsCheck(string input)
    {
        int openBrackets = 0;
        int closingBrackets = 0;

        foreach (var character in input)
        {
            if (character == '(')
            {
                openBrackets++;
            }
            if (character == ')')
            {
                closingBrackets++;
            }
        }
        return openBrackets == closingBrackets;
    }
}

