// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print Invalid number.
// In all cases finally print Good bye.
// Use try-catch-finally block.

using System;
class SquareRoot
{
    static void Main()
    {
        double number = InputNumber();
        PrintSquareRoot(number);
    }
    private static double InputNumber()
    {
        double? num = null;
        do
        {
            Console.WriteLine("Enter a number: ");

            string input = string.Empty;
            try
            {
                input = Console.ReadLine();
                num = int.Parse(input);
            }
            catch(Exception)
            {
                Console.Error.WriteLine("\"{0}\" is not a valid number!", input);
            }

        } while (num == null);

        return (int) num;
    }
    private static void PrintSquareRoot(double num)
    {
        try
        {
            double square = GetSquareRoot(num);
            Console.WriteLine("Square root: {0}", square);
        }
        catch (Exception ex)
        {

            Console.Error.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
    private static double GetSquareRoot(double num)
    {
        double sqrt = 0;
        if (num < 0)
        {
            throw new ArgumentOutOfRangeException("number", "Cannot get square root of a negative number");
        }
        sqrt = Math.Sqrt(num);

        return sqrt;
    }
}
