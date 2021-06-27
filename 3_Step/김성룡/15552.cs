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
            string[] value;
            int a = int.Parse(ReadLine());

            for (int i = 0; i < a; i++)
            {
                value = ReadLine().Split();
                s.Append(int.Parse(value[0]) + int.Parse(value[1]) + "\n");
            }
            WriteLine(s);
        }
    }
}
