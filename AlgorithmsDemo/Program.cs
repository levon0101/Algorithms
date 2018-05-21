using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingSearchngAlgorithms;

namespace AlgorithmsDemo
{
    class Program
    {
        static void ShowBinarySearchExample(int arrCount, int maxValue, int toFind)
        {
            Random r = new Random();

            int[] MyArray = new int[arrCount];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = r.Next(maxValue);
            }

            Array.Sort(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"Index i = {i} value = {MyArray[i]}");
            }
            Console.WriteLine(new string('-',15));
            int interationCount;
            int find = BinarySearcher.Search<int>(MyArray, toFind, out interationCount);
            if (find >= 0)
            {
                Console.WriteLine($"{toFind} data in {find} index, interation - {interationCount}");
            }
            else
            {
                Console.WriteLine($"Not Found, interation - {interationCount}");
            }
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

        static void ShowBubbleSortExample(int conut, bool isLowToHigh)
        {
            Random r = new Random();

            int[] MyArray = new int[conut];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = r.Next(10000);
            }

            BubbleSort<int>.Sort(MyArray, isLowToHigh);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"index i = {i} value = {MyArray[i]}");
            }
        }
        static void Main(string[] args)
        {
             ShowBinarySearchExample(30,100, 31);
            // ShowSelectionSortExample(20);
            //ShowBubbleSortExample(60,false);
            // MathAlgorithms.FibonacciCiclic(5, true);

            Console.ReadKey();
        }
    }
}
