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
            while(true)
            {
                string s1 = Console.ReadLine();
                if (s1 == null)
                    break;

                string[] s2 = s1.Split(' ');
                int a = int.Parse(s2[0]);
                int b = int.Parse(s2[1]);
                Console.WriteLine(a + b);

            }
        }
    }
}