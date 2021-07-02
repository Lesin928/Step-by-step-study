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
            int[] a = new int[10];
            int[] b = new int[42];
            int cnt = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                a[i] %= 42;
                b[a[i]]++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                {
                    cnt++;
                }
            }
            if (cnt == 0)
            {
                cnt = 1;
            }
            WriteLine(cnt);
        }
    }
}
