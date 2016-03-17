//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
//and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SubstringForStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            int index = int.Parse(Console.ReadLine());
            int substringLength = int.Parse(Console.ReadLine());
            var stringBuilder = new StringBuilder(text);
           
            var substring = stringBuilder.Substring(index, substringLength).ToString();
            Console.WriteLine(substring);
        }
    }
}
