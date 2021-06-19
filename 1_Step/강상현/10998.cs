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
            string c = Console.ReadLine();
            string[] cc = c.Split();
            int a = int.Parse(cc[0]);
            int b = int.Parse(cc[1]);
            Console.WriteLine(a * b);       
        }
    }
}