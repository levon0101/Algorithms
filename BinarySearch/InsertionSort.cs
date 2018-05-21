using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSearchngAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr, bool isLowToHigh)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                if (isLowToHigh)
                {
                    while (j >= 0 && arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    arr[j + 1] = key;
                }
                else
                {
                    while (j >= 0 && arr[j] < key)
                    {
                        arr[j + 1] = arr[j];
                        j--;
                    }

                    arr[j + 1] = key;
                }
            }
        }
    }
}
