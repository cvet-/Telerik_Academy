/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement. */

using System;
using System.Threading;
using System.Globalization;

class IntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Please choose:\ni->int\nd->double\ns->string");
        char input = char.Parse(Console.ReadLine());

        switch(input)
        {
            case 'i':
                Console.Write("Please enter an integer: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(i + 1);
                break;
            case 'd':
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(d + 1);
                break;
            case 's':
                Console.Write("Please enter a string: ");
                string s = Console.ReadLine();
                Console.WriteLine(s+'*');
                break;
            default:
                Console.WriteLine("Choose a type!");
                break; 
        }
    }
}

