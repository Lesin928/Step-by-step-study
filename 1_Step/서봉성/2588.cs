using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int a = int.Parse(s1);
            s1 = Console.ReadLine();
            int b = int.Parse(s1);
            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * (b / 10 % 10));
            Console.WriteLine(a * (b / 100 % 10));
            Console.WriteLine(a * b);
        }
    }
}
