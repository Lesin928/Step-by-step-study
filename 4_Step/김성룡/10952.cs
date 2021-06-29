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
            while (true)
            {
                string[] s = ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                int c = a + b;

                if ((a == 0) && (b == 0))
                {
                    break;
                }

                WriteLine(c);
            }
        }
    }
}
