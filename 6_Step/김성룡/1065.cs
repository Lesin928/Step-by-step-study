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
            int n = int.Parse(ReadLine());
            int cnt = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i < 100)
                {
                    cnt++;
                }
                else if ((i > 99) && (i < 1000))
                {
                    int a = i / 100;
                    int b = (i / 10) % 10;
                    int c = i % 10;
                    if ((b - a) == (c - b))
                        cnt++;
                }
            }
            WriteLine(cnt);
        }
    }
}