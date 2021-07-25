using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10872
{
    class Program
    {
        static int pac(int a)
        {
            if(a<=1)
            {
                return 1;
            }
            else
            {
                return a * pac(a - 1);
            }
        }
        static void Main(string[] args)
        {
            int goal = int.Parse(Console.ReadLine());
            int result = pac(goal);
            Console.WriteLine(result);
        }
    }
}
