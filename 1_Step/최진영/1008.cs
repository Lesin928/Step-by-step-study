using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = Console.ReadLine();
            string[] m = i.Split();
            double a = double.Parse(m[0]);
            double b = double.Parse(m[1]);
            Console.Write("{0}", a / b);
        }
    }
}