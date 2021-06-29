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
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int val1 = n, val2 = 100;

            while(val2 != n)
            {
                val2 = (val1 % 10 * 10) + (val1 / 10 + val1 % 10) % 10;
                val1 = val2;
                count++;              
            }

            Console.WriteLine(count);
        }
    }
}