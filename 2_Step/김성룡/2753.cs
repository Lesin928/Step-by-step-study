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

            if ((a % 4 == 0) && (a % 100 != 0))
            {
                WriteLine(1);
            }
            else if ((a % 4 == 0) && (a % 400 == 0))
            {
                WriteLine(1);
            }
            else
                WriteLine(0);
        }
    }
}
