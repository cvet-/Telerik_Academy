using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int counter = 2; counter <= 1000; counter++)
        {
            if (counter % 2 == 0)
            {
                Console.Write(counter + ",");
            }
            else
            {
                Console.Write(-counter);
                if (counter < 1000)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}

