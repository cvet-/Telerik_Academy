using System;

class PrintASequence
{
    static void Main()
    {
        for (int counter = 2; counter <= 10; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.Write(counter + ", ");
            }
            else
            {
                Console.Write(-counter);
                if (counter < 10)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
    }
}
