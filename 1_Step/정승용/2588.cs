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
            int  a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int num1 = b;
            int num2 = num1;

            while (num2 > 0)
            {
                num1 = num2 % 10;
                Console.WriteLine(a*num1);
                num2 /= 10;
            }
            Console.WriteLine(a * b);
        }
    }
}
