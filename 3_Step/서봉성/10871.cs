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
            string[] s1 = Console.ReadLine().Split(' ');

            int n = int.Parse(s1[0]);
            int x = int.Parse(s1[1]);

            string[] s2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                int val = int.Parse(s2[i]);
                if (x > val)
                    Console.Write(val + " ");
            }

        }
    }
}