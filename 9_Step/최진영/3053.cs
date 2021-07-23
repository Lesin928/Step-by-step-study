using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3053
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double uclid = Math.PI * (double)Math.Pow(a, 2);
            double taxi = 2 * (double)Math.Pow(a, 2);
            Console.WriteLine("{0:f6}",uclid);
            Console.WriteLine("{0:f6}", taxi);
        }
    }
}
