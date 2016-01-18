/* Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
 The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
Use 2 nested for-loops and a switch-case statement. */

using System;

class PrintADeckOfCards
{
    static void Main()
    {
        // Console.WriteLine( "Enter card number");
        // int card=int.Parse(Console.ReadLine());
        int a = 3;
        int b = 4;
        int c = 5;
        int d = 6;
        // Console.WriteLine((char) a);
        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine(" " + i + " of spades," + " " + i + " of clubs," + " " + i + " of hearts," + " " + i + " of diamonds");

            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine(" D " + " of spades," + "D " + " of clubs," + "D " + " of hearts," + "D " + " of diamonds"); break;
                        case 12: Console.WriteLine(" A " + " of spades," + "A " + " of clubs," + "A " + " of hearts," + "A " + " of diamonds"); break;
                        case 13: Console.WriteLine(" J " + " of spades," + "J " + " of clubs," + "J " + " of hearts," + "J " + " of diamonds"); break;
                        case 14: Console.WriteLine(" K " + " of spades," + "K " + " of clubs," + "K " + " of hearts," + "K " + " of diamonds"); break;
                    }
            }
        }
    }
}


