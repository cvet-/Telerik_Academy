// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter card's sign: ");
        string card = Console.ReadLine();
        string[] signs = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        if (Array.IndexOf(signs, card) >= 0)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
