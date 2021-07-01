using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000000022222222
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
                int b, d;
                int c = a;
                int count = 0;
                while (true)
                {
                    count++;
                    b = c / 10;
                    d = c % 10;
                c = d * 10 + ((b + d) % 10);
                 if (c == a)
                   break; 
            }
            Console.WriteLine(count);
        }
    }
}