using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int b =1;b<10;b++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
        }
    }
}
