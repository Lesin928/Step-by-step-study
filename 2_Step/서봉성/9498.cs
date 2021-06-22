using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(str);

            if (a >= 90)
                Console.WriteLine('A');
            else if(a>=80)
                Console.WriteLine('B');
            else if (a >= 70)
                Console.WriteLine('C');
            else if (a >= 60)
                Console.WriteLine('D');
            else
                Console.WriteLine('F');
        }
    }
}
