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
            int val = 0;
            for(int i=1; i<=n; i++)
            {
                val += i;
            }
            Console.Write(val);
        }
    }
}
