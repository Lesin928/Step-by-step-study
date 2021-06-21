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
            string c = Console.ReadLine();
            string[] cc = c.Split();

            int a = int.Parse(cc[0]);
            int b = int.Parse(cc[1]);

            if (b>=45)
            {
                b = b - 45;
                Console.WriteLine("{0} {1}", a, b);
            }
            else
            {
                b = b + 15;
                

                if (a == 0)
                {
                    a = 23;
                    Console.WriteLine("{0} {1}", a, b);
                }
                else
                {
                    a = a - 1;
                    Console.WriteLine("{0} {1}", a, b);
                }
            }
        }
    }
}