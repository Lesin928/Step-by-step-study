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
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                int a = int.Parse(s1[0]);
                int b = int.Parse(s1[1]);
                sb.Append("Case #"+i+": "+(a+b)+"\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}