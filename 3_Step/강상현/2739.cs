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
            int a = int.Parse(Console.ReadLine());

            for(int i=1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
        }
    }
}