using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8393
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            int a = int.Parse(Console.ReadLine());
            for(int i=1;i<=a;i++)
            {
                b = b + i;
            }
            Console.WriteLine("{0}", b);
        }
    }
}
