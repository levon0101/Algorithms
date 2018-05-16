using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDemo
{
    static class MathAlgorithms
    {
        public static int FibonacciCiclic(int numToFind, bool showWhileToFind)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < numToFind; i++)
            {
                int tmp = a;
                a = b;
                b = tmp + b;
                if (showWhileToFind)
                {
                    Console.WriteLine($"Fibonacci num of {i+1} = {a}");
                }
            }

            if (!showWhileToFind)
            {
                Console.WriteLine($"Fibonacci num of {numToFind} = {a}");
            }

            return a;
        }

    }
}
