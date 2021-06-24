using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i=0;i<a;i++)
            {
                string s = Console.ReadLine();
                string[] v = s.Split();
                int first = int.Parse(v[0]);
                int second = int.Parse(v[1]);
                Console.WriteLine("{0}", first + second);
            }
        }
    }
}
