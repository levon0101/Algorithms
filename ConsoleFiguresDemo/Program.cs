using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFiguresDemo
{
    class Program
    {
        static string line = "------------------";
        static void Main(string[] args)
        {
            Figures.Pyramide(15);

            Console.WriteLine(line);

            Figures.TrangleV1(15);

            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
