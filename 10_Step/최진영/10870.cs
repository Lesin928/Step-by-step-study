using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10870
{
    class Program
    {
        static int calc = 0;
        static int basic = 1;
        static int change = 0;
        static int pibo(int a)
        {
            
            calc = basic +change;
            basic = change;
            change = calc;
            if (a == 0)
            {
                return 0;
            }
            else if (a <= 1)
            {
                return calc;
            }
            
            else
            {
                Console.WriteLine(calc); Console.WriteLine(basic); Console.WriteLine(change);
                return pibo(a - 1);
            }

        }
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int result = pibo(count);
            Console.WriteLine(result);
        }
    }
}
