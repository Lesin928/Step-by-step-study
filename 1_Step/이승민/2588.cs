using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", b % 10 * a , ( (b / 10) - (b / 100 * 10) ) * a, b / 100 * a ,a*b);
        }
    }
}

