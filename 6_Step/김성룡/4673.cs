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
        static int D(int n)
        {
            int num = 0;
            if (n < 10)
            {
                num = n + n;
            }
            else if ((n > 9) && (n < 100))
            {
                num = n + (n / 10) + (n % 10);
            }
            else if ((n > 99) && (n < 1000))
            {
                num = n + (n / 100) + ((n % 100) / 10) + (n % 10);
            }
            else if ((n > 999) && (n < 10000))
            {
                num = n + (n / 1000) + ((n % 1000) / 100) + ((n % 100) / 10) + (n % 10);
            }
            return num;
        }
        static void Main(string[] args)
        {
            int[] a = new int[10001];
            for (int i = 1; i < 10001; i++)
            {
                a[D(i)] = 1;
                if (D(i) >= 10000)
                    break;
            }
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] != 1)
                {
                    WriteLine(i);
                    if (i >= 9993)
                        break;
                }
            }
        }
    }
}