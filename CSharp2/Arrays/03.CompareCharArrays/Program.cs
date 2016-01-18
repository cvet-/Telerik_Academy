using System;

class Program
{
     static void Main()
    {
              
        char[] firstArray = { 'h', 'e', 'l', 'l', 'o' };
        char[] secondArray = { 'h', 'e', 'l', 'l','o','u' };
        
        bool areEqual = true;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                }
            }
            Console.WriteLine(areEqual);
        }
        else
        {
            areEqual = false;
            Console.WriteLine(areEqual);
        }

    }
}
