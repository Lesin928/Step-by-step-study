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
            StringBuilder b = new StringBuilder();

            for (int i = a; i > 0; i--)
            {
                b.Append(i + "\n");
            }

            Console.WriteLine(b);
        }
    }
}