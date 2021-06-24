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
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            for(int i=1;i<=9;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, n * i);
            }
        }
    }
}
