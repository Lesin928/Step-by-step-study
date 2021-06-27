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
            StringBuilder s = new StringBuilder();
            int a = int.Parse(ReadLine());

            for (int i = a; i >= 1; i--)
            {
                s.AppendLine(i.ToString());
            }
            WriteLine(s);
        }
    }
}
