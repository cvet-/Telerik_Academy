// Problem 14: Print the ASCII table 

using System;

class Program
{
    static void Main()
    {
        int a = 1; 
        for (int i = 0; i < 250; i++)    // Prints ASCII characters from 1 to 250

        Console.Write((char)i + "\t"); // Performing type casting
        Console.ReadKey();            // Obtains the next character or function key pressed by the user

    }
}


