using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            string[] s = ReadLine().Split(' ');
            int[] b = new int[a];
            int min, max;
            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(s[i]);
            }
            min = b[0];
            max = b[0];
            for (int i = 0; i < a; i++)
            {
                if (b[i] < min)
                {
                    min = b[i];
                }
                else if (b[i] > max)
                {
                    max = b[i];
                }
            }
            WriteLine(min + " " + max);
        }
    }
}
