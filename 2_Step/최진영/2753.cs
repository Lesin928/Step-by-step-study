using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2753
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a%4==0&&a%100!=0)
            {
                Console.WriteLine("1");
            }
            else if (a % 100 == 0 && a % 400 != 0)
            {
                Console.WriteLine("0");
            }
            else if (a % 400 == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
