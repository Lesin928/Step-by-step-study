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
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int a = int.Parse(str1);
            int b = int.Parse(str2);

            if (a >= 0 && b >= 0)
                Console.WriteLine('1');
            else if (a < 0 && b >= 0)
                Console.WriteLine('2');
            else if (a < 0 && b < 0)
                Console.WriteLine('3');
            else
                Console.WriteLine('4');
        }
    }
}
