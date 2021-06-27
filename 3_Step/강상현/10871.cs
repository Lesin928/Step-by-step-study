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
            string a = Console.ReadLine();
            string[] c = a.Split();
            StringBuilder b = new StringBuilder();
            int time = int.Parse(c[0]);
            int num = int.Parse(c[1]);
            string q = Console.ReadLine();
            string[] cc = q.Split();

            for (int i = 0; i < time; i++)
            {
                int w = int.Parse(cc[i]);

                if (w < num)
                {
                    b.Append(cc[i] + " ");
                }
            }

            Console.WriteLine(b);
        }
    }
}