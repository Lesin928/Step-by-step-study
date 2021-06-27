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

            for (int i = 1; i <= 9; i++)
            {
                WriteLine(a + " * " + i + " = " + a * i);
            }
        }
    }
}
