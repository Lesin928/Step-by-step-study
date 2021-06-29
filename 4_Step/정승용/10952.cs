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
            while (true) {

                string[] st = Console.ReadLine().Split();
                int a = int.Parse(st[0]);
                int b = int.Parse(st[1]);
                if (a == 0 && b == 0)
                {
                    break;

                }

                Console.WriteLine(a+b);
            }

         


		}
    }
}