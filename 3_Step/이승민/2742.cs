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
            int N = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append(N-i + "\n");
            }
            Console.WriteLine(sb);

        }
    }
}

