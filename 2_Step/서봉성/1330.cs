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
            string[] str = Console.ReadLine().Split(' ');
            int a = int.Parse(str[0]);
            int b = int.Parse(str[1]);
            if (a > b)
                Console.WriteLine('>');
            else if (a < b)
                Console.WriteLine('<');
            else
                Console.WriteLine("==");

        }
    }
}
