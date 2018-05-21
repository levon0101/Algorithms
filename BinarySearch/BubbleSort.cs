using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSearchngAlgorithms
{
    public static class BubbleSort<T> where T : IComparable
    {
        public static void Sort(T[] arr, bool isLowToHigh)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isLowToHigh)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        if (arr[j].CompareTo(arr[j - 1]) < 0)
                        {
                            T tmp = arr[j];
                            arr[j] = arr[j - 1];
                            arr[j - 1] = tmp;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < arr.Length - 1- i; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) < 0)
                        {
                            T tmp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = tmp;
                        }
                    }
                }

            }
        }


    }
}
