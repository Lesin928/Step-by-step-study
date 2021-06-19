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
            string[] s1 = Console.ReadLine().Split(' ');
            int a = int.Parse(s1[0]);
            int b = int.Parse(s1[1]);
            Console.WriteLine(a * b);
        }
    }
}
