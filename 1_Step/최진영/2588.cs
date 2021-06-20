using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2588
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", a * (b % 10));
            Console.WriteLine("{0}", a * ((b / 10)%10));
            Console.WriteLine("{0}", a * (b / 100));
            Console.WriteLine("{0}", a * b);
        }
    }
}
