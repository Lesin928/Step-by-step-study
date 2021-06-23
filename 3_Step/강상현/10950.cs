using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000000022222222
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                string d = Console.ReadLine();
                string[] cc = d.Split();
                int q = int.Parse(cc[0]);
                int w = int.Parse(cc[1]);

                Console.WriteLine(q+w);
            }
        }
    }
}