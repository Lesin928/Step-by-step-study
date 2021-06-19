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

            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);

            WriteLine(a / b);
        }
    }
}



