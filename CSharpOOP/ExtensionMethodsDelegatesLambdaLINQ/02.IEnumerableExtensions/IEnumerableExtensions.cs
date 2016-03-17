using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IEnumerableExtensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }

            dynamic sum = default(T);
            foreach (var item in enumerable)
            {
                sum += item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }

            dynamic product = 1;
            foreach (var item in enumerable)
            {
                product *= item;
            }
            return product;
        }
        public static T Min<T>(this IEnumerable<T> enumerable) where T : IComparable
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }
            if (!enumerable.Any())
            {
                return default(T);
            }
            dynamic min = enumerable.First();
            foreach (var item in enumerable)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumerable) where T : IComparable
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }
            if (!enumerable.Any())
            {
                return default(T);
            }
            dynamic max = enumerable.First();
            foreach (var item in enumerable)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> enumerable) where T: IComparable
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException();
            }
            return (dynamic)enumerable.Sum() / enumerable.Count();
        }
    }
}
