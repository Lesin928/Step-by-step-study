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
            StringBuilder b = new StringBuilder();

            for (int i = 1; i < a+1; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    b.Append("*");
                }

                b.Append("\n");
            }

            Console.WriteLine(b);
        }
    }
}