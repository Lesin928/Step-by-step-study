using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < T; i++)
            {
                string[] AB = Console.ReadLine().Split(' ');
                sb.Append(Convert.ToInt32(AB[1])+Convert.ToInt32(AB[0]) + "\n");
            }
            Console.WriteLine(sb);

        }
    }
}

