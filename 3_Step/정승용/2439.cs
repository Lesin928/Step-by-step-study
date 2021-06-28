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
            int val = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < val+1; i++) {

                sb.Append(' ', val-i);
                sb.Append('*', i);
                sb.Append("\n");

            }


            Console.Write(sb);
        }
    }
}