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
            string[] s1 = ReadLine().Split(' ');
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int[] c = new int[a];

            for (int i = 0; i < a; i++)
            {
                c[i] = int.Parse(s1[i]);
                if (c[i] < b)
                {
                    Write(c[i] + " ");
                }
            }
            WriteLine();
        }
    }
}
