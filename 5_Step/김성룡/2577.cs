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
            int b = int.Parse(ReadLine());
            int c = int.Parse(ReadLine());
            int[] d = new int[10];
            int e = a * b * c;
            while (true)
            {
                if (e == 0)
                    break;
                int num = e % 10;
                d[num]++;
                e /= 10;
            }
            for (int i = 0; i < d.Length; i++)
            {
                WriteLine(d[i]);
            }
        }
    }
}
