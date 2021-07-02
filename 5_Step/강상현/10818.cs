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
            string b = Console.ReadLine();
            string[] c = b.Split();
            int max = int.Parse(c[0]), min = int.Parse(c[0]);

            for (int i = 0; i < a; i++)
            {
                if (int.Parse(c[i]) > max)
                {
                    max = int.Parse(c[i]);
                }
                else if (int.Parse(c[i]) < min)
                {
                    min = int.Parse(c[i]);
                }
            }
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}