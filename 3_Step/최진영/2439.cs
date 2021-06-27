using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2439
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder star = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                for (int j = a; j >= 1; j--)
                {
                    if (j > i)
                    {
                        star.Append(" ");
                    }
                    else
                    {
                        star.Append("*");
                    }
                }
                star.Append("\n");
            }
            Console.WriteLine(star.ToString());
        }
    }
}
