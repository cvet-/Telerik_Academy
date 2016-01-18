// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Enter an integer between 0 and 999: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 999)
        {
            Console.Write("Invalid input. Enter an integer between 0 and 999: ");
            number = int.Parse(Console.ReadLine());
        }
        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int digits = number % 10;
        int xteen = 10 + digits;
        string teensToWords = "";
        string hundredsToWords = "";
        string tensToWords = "";
        string digitsText;

        switch (digits)
        {
            case 1: digitsText = "one"; break;
            case 2: digitsText = "two"; break;
            case 3: digitsText = "three"; break;
            case 4: digitsText = "four"; break;
            case 5: digitsText = "five"; break;
            case 6: digitsText = "six"; break;
            case 7: digitsText = "seven"; break;
            case 8: digitsText = "eight"; break;
            case 9: digitsText = "nine"; break;
            default: digitsText = ""; break;
        }

        switch (xteen)
        {
            case 11: teensToWords = "eleven"; break;
            case 12: teensToWords = "twelve"; break;
            case 13: teensToWords = "thirteen"; break;
            case 14: teensToWords = "fourteen"; break;
            case 15: teensToWords = "fifteen"; break;
            case 16: teensToWords = "sixteen"; break;
            case 17: teensToWords = "seventeen"; break;
            case 18: teensToWords = "eighteen"; break;
            case 19: teensToWords = "nineteen"; break;
        }

        switch (tens)
        {
            case 1: tensToWords = "ten"; break;
            case 2: tensToWords = "twenty "; break;
            case 3: tensToWords = "thirty "; break;
            case 4: tensToWords = "fourty "; break;
            case 5: tensToWords = "fifty "; break;
            case 6: tensToWords = "sixty "; break;
            case 7: tensToWords = "seventy "; break;
            case 8: tensToWords = "eighty "; break;
            case 9: tensToWords = "ninety "; break;
            case 0: tensToWords = ""; break;
        }

        switch (hundreds)
        {
            case 1: hundredsToWords = "one hundred "; break;
            case 2: hundredsToWords = "two hundred "; break;
            case 3: hundredsToWords = "three hundred "; break;
            case 4: hundredsToWords = "four hundred "; break;
            case 5: hundredsToWords = "five hundred "; break;
            case 6: hundredsToWords = "six hundred "; break;
            case 7: hundredsToWords = "seven hundred "; break;
            case 8: hundredsToWords = "eight hundred "; break;
            case 9: hundredsToWords = "nine hundred "; break;
            case 0: hundredsToWords = ""; break;
        }
        if (number % 100 != 0 && number >= 100)
        {
            hundredsToWords = hundredsToWords + "and ";
        }
        if (tens == 1 && digits > 0)
        {
            Console.WriteLine(hundredsToWords + xteen);
            hundredsToWords = tensToWords = "";
        }                    

        if (number == 0)
        {
            Console.WriteLine("Zero");
            hundredsToWords = tensToWords = digitsText = "";
        }
        if (number <= 10 || number >= 20)
        {
            Console.WriteLine(hundredsToWords + tensToWords + digitsText);
        }

    }
}

