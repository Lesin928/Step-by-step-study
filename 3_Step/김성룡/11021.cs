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
            //StringBuilder s = new StringBuilder();
            //string[] value;
            int a = int.Parse(ReadLine());
            int[] b = new int[a];
            int[] c = new int[a];

            for (int i = 0; i < a; i++)
            {
                //value = ReadLine().Split();
                //s.Append(int.Parse(value[0]) + int.Parse(value[1]));
                string[] s = ReadLine().Split(' ');
                b[i] = int.Parse(s[0]);
                c[i] = int.Parse(s[1]);
            }
            for (int i = 0; i < a; i++)
            {
                WriteLine("Case #" + (i + 1) + ": " + (b[i] + c[i]));
            }
        }
    }
}
