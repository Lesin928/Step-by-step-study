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
            while(true)
            {
                string a = Console.ReadLine();
                if (a == null)
                    break;

                string[] c = a.Split();
                int q = int.Parse(c[0]);
                int w = int.Parse(c[1]);
                Console.WriteLine(q + w);
            }
        }
    }
}