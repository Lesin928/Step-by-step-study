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
            int b = int.Parse(s[1]);

            WriteLine(a + b);
            WriteLine(a - b);
            WriteLine(a * b);
            WriteLine(a / b);
            WriteLine(a % b);
        }
    }
}




