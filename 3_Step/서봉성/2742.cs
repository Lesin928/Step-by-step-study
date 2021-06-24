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

            for (int i = n; i > 0; i--)
            {
                sb.Append(i + "\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
