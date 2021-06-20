using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10430
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = Console.ReadLine();
            string[] m = i.Split();
            int a = int.Parse(m[0]);
            int b = int.Parse(m[1]);
            int c = int.Parse(m[2]);
            Console.Write("{0}\n", (a + b) % c);
            Console.Write("{0}\n", ((a % c) + (b % c)) % c);
            Console.Write("{0}\n", (a * b) % c);
            Console.Write("{0}\n", ((a % c) * (b % c)) % c);
        }
    }
}
