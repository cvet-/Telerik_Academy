using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DivisibleBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 26, 28, 3, 14, 21, 63 };

            var sortedByLambda = SelectWithLambda(numbers);
            PrintSortedNums("With Lambda", sortedByLambda);
            Console.WriteLine();

            var sortedByLinq = SelectWithLINQ(numbers);
            PrintSortedNums("With Linq", sortedByLinq);
        }
        private static IEnumerable<int> SelectWithLINQ(IEnumerable<int> numbers)
        {
            var sortedNums =
                from n in numbers
                where n % 3 == 0 && n % 7 == 0
                select n;
            return sortedNums.ToArray();
        }
        private static IEnumerable<int> SelectWithLambda(IEnumerable<int> numbers)
        {
            return numbers.Where(n => n % 3 == 0 && n % 7 == 0).ToArray();
        }
        private static void PrintSortedNums(string title, IEnumerable<int> numbers)
        {
            Console.WriteLine(title);
            foreach (var num in numbers)
            {
                Console.WriteLine("{0}", num);
            }
            Console.WriteLine();

        }
    }
}
