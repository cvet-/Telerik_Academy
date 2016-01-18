/* Problem 9: Declare two integer variables a and b and assign them with 5 and 10 
 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange. */

using System;

class ExchangeValues
{
    static void Main()
    {
        // Assigning the variables
        int a = 5;
        int b = 10;
        Console.WriteLine("Before exchange:\na={0}\nb={1}", a,b);

        int swap = a; // Creating a ref parameter swap that takes the reference of the value of a, now swap holds the value of a
        a = b;       // Swaping the values of a and b, now a holds the value of b
        b = swap;   // b gets the value of swap (swap == the value of a), the values of a and b has been exchanged
        Console.WriteLine("After exchange:\na = {0}\nb = {1}", a,b);       
    }
}

