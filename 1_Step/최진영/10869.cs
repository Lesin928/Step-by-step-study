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
            int a = int.Parse(m[0]);
            int b = int.Parse(m[1]);
            Console.Write("{0}\n", a + b);
            Console.Write("{0}\n", a - b);
            Console.Write("{0}\n", a * b);
            Console.Write("{0}\n", a / b);
            Console.Write("{0}\n", a % b);
        }
    }
}
