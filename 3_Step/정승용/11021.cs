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
            int j = int.Parse(Console.ReadLine());
            StringBuilder ar = new StringBuilder();

            for (int i = 1; i <= j; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                ar.Append("Case #" +i+": "+ (a + b)).Append("\n");
            }
            Console.WriteLine(ar.ToString());

        }
    }
}