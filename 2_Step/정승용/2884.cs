using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int h = int.Parse(a[0]);
            int m = int.Parse(a[1]);

            m -= 45;

            if (m < 0) { h -= 1; m += 60; }
            if (h < 0) h += 24;

            WriteLine(h + " " + m);



        }
    }
}