using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class LargerThanNeighbours
    {
        public static bool CheckLargerThanNeighbors(int[] array, int index)
        {
            if (array[index - 1] < array[index] && array[index] > array[index + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
