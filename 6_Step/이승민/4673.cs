using System;
using System.Text;
using System.Linq;
namespace 백준1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int[] a = new int[10100];
            for (int i = 1; i < 10000; i++)
            {
                a[SelfNum.Dnum(i)] += 1;

            }
            for (int i = 1; i < 10000; i++)
            {
                if (a[i] == 0)
                {
                    sb.Append(i + "\n");
                }
            }
            Console.WriteLine(sb);
        }
    }
    class SelfNum
    {
        public static int Dnum(int x)
        {
            int y = 0;
            if (0 <= x && x < 10)
            {
                y = x + x;
            }
            else if (10 <= x && x < 100)
            {
                y = x + x % 10 + x / 10;
            }
            else if (100 <= x && x < 1000)
            {
                y = x + (x % 100 % 10) + (x % 100 / 10) + (x / 100);
            }
            else if (1000 <= x && x < 10000)
            {
                y = x + (x % 1000 % 100 % 10) + (x % 1000 % 100 / 10) + (x % 1000 / 100) + (x / 1000);
            }
            return y;
        }
    }
}