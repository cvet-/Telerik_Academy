using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class LongestString
    {
        static void Main()
        {
            string[] stringArr = new[]  {"string", "Hello, World!", "what", "is", "this" };
            
            Console.WriteLine(GetLongestString(stringArr));
        }

        public static string GetLongestString(string[] input)
        {
            var longest =
                from strings in input
                orderby strings.Length descending
                select strings;

            return longest.ToArray()[0];
        }
    }
}
