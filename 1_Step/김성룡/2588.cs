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
            int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());

            WriteLine(a * (b % 10));
            WriteLine(a * ((b % 100) / 10));
            WriteLine(a * (b / 100));
            WriteLine(a * b);
        }
    }
}




