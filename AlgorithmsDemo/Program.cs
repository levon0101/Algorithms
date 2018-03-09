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
        static void Main(string[] args)
        {
            Random r = new Random();

            int[] MyArray = new int[1000];

            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = r.Next(10000); 
            }

            Array.Sort(MyArray);

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"index i = {i} value = {MyArray[i]}");
            }
            
            BinarySearcher.Search(MyArray,0);

            Console.ReadKey();
        }
    }
}
