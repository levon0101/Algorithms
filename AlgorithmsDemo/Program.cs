using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinarySearch;

namespace AlgorithmsDemo
{
    class Program
    {
        static void ShowBinarySearchExample(int count)
        {
            Random r = new Random();

            int[] MyArray = new int[count];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = r.Next(10000);
            }

            Array.Sort(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"index i = {i} value = {MyArray[i]}");
            }

            BinarySearcher.Search(MyArray, 0);
        }

        static void ShowSelectionSortExample(int conut)
        {
            Random r = new Random();

            int[] MyArray = new int[conut];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = r.Next(10000);
            }

            SelectionSort<int>.Sort(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"index i = {i} value = {MyArray[i]}");
            }
        }
        static void Main(string[] args)
        {
            // ShowBinarySearchExample(60);
            ShowSelectionSortExample(20);
           // MathAlgorithms.FibonacciCiclic(5, true);

            Console.ReadKey();
        }
    }
}
