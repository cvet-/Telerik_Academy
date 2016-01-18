/* You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by space: ");
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        long oddProduct = 1;
        long evenProduct = 1;

        for (int index = 0; index < numbers.Length; index++)
        {
            if (index % 2 == 0)
                oddProduct *= numbers[index];

            else evenProduct *= numbers[index];
        }

       
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}


