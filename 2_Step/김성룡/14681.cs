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

            if ((a > 0) && (b > 0))
            {
                WriteLine(1);
            }
            else if ((a < 0) && (b > 0))
            {
                WriteLine(2);
            }
            else if ((a < 0) && (b < 0))
            {
                WriteLine(3);
            }
            else if ((a > 0) && (b < 0))
            {
                WriteLine(4);
            }
        }
    }
}
