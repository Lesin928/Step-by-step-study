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
            string str = Console.ReadLine();
            int a = int.Parse(str);

            if (a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
                Console.WriteLine('1');
            else
                Console.WriteLine('0');
        }
    }
}
