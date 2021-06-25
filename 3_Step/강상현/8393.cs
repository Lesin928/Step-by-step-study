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
            int b = 0;

            for(int i = 1; i < a+1; i++) {
                b = b + i;
            }

            Console.WriteLine(b);
        }
    }
}