using System;

namespace SortingSearchngAlgorithms
{
    public class BinarySearcher
    {

        public static int Search<T>(T[] arr, T toFind, out int interationCount) where T : IComparable
        {

            int low = 0;
            int high = arr.Length - 1;
            interationCount = 0;
            int location = -1;
            do
            {
                interationCount++;
                int middle = (high + low+1) / 2;
                if (toFind.CompareTo(arr[middle]) < 0)
                {
                    high = middle-1;
                }
                else if (toFind.CompareTo(arr[middle]) > 0)
                {
                    low = middle+1;
                }
                else
                {
                    location = middle;
                }
            }
            while (low <= high && location == -1);
            return location;
        }
        public static int Search(int[] myArray, int toFind)
        {
            int index = myArray.Length / 2;

            return 0;
        }
    }

}