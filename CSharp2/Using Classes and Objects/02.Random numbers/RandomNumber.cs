﻿// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumber
{
    static void Main()
    {
        Random rnd = new Random();
        Console.WriteLine("Ten random numbers: ");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(rnd.Next(100,201));
        }
    }
}

