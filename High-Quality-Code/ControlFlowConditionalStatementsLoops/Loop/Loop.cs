namespace Loop
{
    using System;

    public class Loop
    {
        public static void Main()
        {
            int finalValue = 0;

            for (int i = 0; i < 100; i++)
            {
                int currentValue = array[i];
                Console.WriteLine(currentValue);

                if ((i % 10 == 0) && (currentValue == expectedValue))
                {
                    finalValue = 666;
                    break;
                }
            }

            //More code here

            if (finalValue == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}