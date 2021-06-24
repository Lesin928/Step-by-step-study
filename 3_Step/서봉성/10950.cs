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
            for(int i=0;i<n;i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                int a = int.Parse(s2[0]);
                int b = int.Parse(s2[1]);
                Console.WriteLine(a+b);
            }
        }
    }
}
