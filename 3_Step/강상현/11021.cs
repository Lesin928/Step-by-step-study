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

            for (int i = 1; i < a+1; i++)
            {
                string d = Console.ReadLine();
                string[] cc = d.Split();
                int q = int.Parse(cc[0]);
                int w = int.Parse(cc[1]);
                int f = q + w;

                b.Append("Case #" + i + ": "+ f + "\n");
            }

            Console.WriteLine(b);
        }
    }
}