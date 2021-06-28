using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b;
            int c;
            int d=0;
            int i = 0;
            if (a <= 9)
            {
                a = a * 10;
            }
            int e = a;
            while (true)
            {
                b = a / 10;
                c = a % 10;
                d = b + c;
                if (d > 9)
                {
                    d = d % 10;
                }
                a = (c * 10) + d;
                i++;
                if (e == a)
                {
                    Console.WriteLine("{0}", i);
                    break;
                }
            }
        }
    }
}
