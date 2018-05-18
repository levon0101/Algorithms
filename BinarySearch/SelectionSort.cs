using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class SelectionSort<T> where T : IComparable
    {
        public static void Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minPos = minPosition(arr, i);
                if (arr[i].CompareTo(arr[minPos]) != 0)
                {
                    T tmp = arr[i];
                    arr[i] = arr[minPos];
                    arr[minPos] = tmp;
                }

            }
        }

        private static int minPosition(T[] arr, int startIndex)
        {
            int minPos = startIndex;
            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (arr[minPos].CompareTo(arr[i]) > 0)
                {
                    minPos = i;
                }
            }
            return minPos;
        }
    }
}
