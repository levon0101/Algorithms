using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDemo
{
    class test
    {
        private int _numOfVariables = 0;
        public int[] arr;
        public test(string data)
        {
            arr = new int[VarCounter(data)];
        }

        public int VarCounter(string s)
        {
            foreach (char c in s)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    _numOfVariables++;
                }
            }

            return _numOfVariables;
        }

        4
    }
}
