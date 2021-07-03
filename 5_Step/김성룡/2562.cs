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
            int[] b = new int[9];
            int max = b[0];
            int cnt = 0;
            for (int i = 0; i < 9; i++)
            {
                b[i] = int.Parse(ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                    cnt = i + 1;
                }
            }
            WriteLine(max);
            WriteLine(cnt);
        }
    }
}
