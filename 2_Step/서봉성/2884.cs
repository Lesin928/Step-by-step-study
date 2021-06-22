using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);

            b -= 45;
            if(b<0)
            {
                a -= 1;
                b += 60;
                if (a < 0)
                    a += 24;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
