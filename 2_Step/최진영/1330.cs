using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string s = Console.ReadLine();
            string[] m = s.Split();
            a = int.Parse(m[0]);
            b = int.Parse(m[1]);
            if(a<b)
            {
                Console.WriteLine("<");
            }
            else if(a==b)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(">");
            }
        }
    }
}
