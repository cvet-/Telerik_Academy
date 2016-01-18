//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
namespace _06.First_larger_than_neighbours
{
    class FirstLarger
    {
        public static int IndexOfFirstBiggest(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 2; i++)
            {
                if (LargerThanNeighbours.CheckLargerThanNeighbors(numbers, i) == true)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the Array indexes:");

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The first element in array that is bigger than its neighbors is: {0}", IndexOfFirstBiggest(array));
        }
    }
}



