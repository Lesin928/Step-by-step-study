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
            StringBuilder b = new StringBuilder();
            while(true)
            {
                string a = Console.ReadLine();
                string[] c = a.Split();

                if (a == "0 0")
                    break;

                int q = int.Parse(c[0]);
                int w = int.Parse(c[1]);

                b.Append(q + w + "\n");
            }

            Console.WriteLine(b);
        }
    }
}