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
            int[] b = new int[a];
            int[] c = new int[a];
            for (int i = 0; i < a; i++)
            {
                string[] s = ReadLine().Split(' ');
                b[i] = int.Parse(s[0]);
                c[i] = int.Parse(s[1]);
            }
            for (int i = 0; i < a; i++)
            {
                WriteLine(b[i] + c[i]);
            }
        }
    }
}
