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

            for (int i = 0; i < a; i++)
            {
                for(int k = i; k < a-1; k++)
                {
                    b.Append(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    b.Append("*");
                }
                b.Append("\n");
            }

            Console.WriteLine(b);
        }
    }
}