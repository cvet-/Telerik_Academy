using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    class Program
    {
        static void Main()
        {
            BitArray64 bitArray = new BitArray64(263);

            Console.WriteLine(bitArray.ToString());

            ShowIndexValue(bitArray, 0);
            ShowIndexValue(bitArray, 1);
            ShowIndexValue(bitArray, 2);
            ShowIndexValue(bitArray, 3);
            Console.WriteLine();

            BitArray64 bitArray2 = new BitArray64(125);
            Console.WriteLine("Array 2:");
            Console.WriteLine(bitArray2.ToString());
            Console.WriteLine();

            Console.WriteLine("The arrays are equal - {0}.", bitArray == bitArray2);
        }

        private static void ShowIndexValue(BitArray64 array, int index)
        {
            Console.WriteLine("Value at index {0} is {1}.", index, array[index]);
        }
    }
}


