using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFiguresDemo
{
    static class Figures
    {
        public static void Pyramide(int width)
        {
            for (int i = 0; i < width/2; i++)
            {
                Console.Write(new string(' ', width/2-i-1));
                Console.Write("*");
                Console.WriteLine(new string('*', i*2));
            }

        }

        public static void TrangleV1(int width)
        {
            for (int i = 0; i < width; i++)
            {
                Console.Write(new string(' ', width-i-1));
                Console.Write("*");
                Console.WriteLine(new string('*', i));
            }
        }

    }
}
