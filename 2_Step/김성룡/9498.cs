using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = ReadLine().Split(' ');

            int a = int.Parse(s[0]);

            if (a >= 90)
            {
                WriteLine('A');
            }
            else if (a >= 80)
            {
                WriteLine('B');
            }
            else if (a >= 70)
            {
                WriteLine("C");
            }
            else if (a >= 60)
            {
                WriteLine("D");
            }
            else
            {
                WriteLine("F");
            }
        }
    }
}
