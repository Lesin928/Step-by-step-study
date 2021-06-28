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
			string[] val1 = Console.ReadLine().Split();
			int x = int.Parse(val1[0]);
			int y = int.Parse(val1[1]);

			string[] val2 = Console.ReadLine().Split();
			StringBuilder sb = new StringBuilder();

			int[] numbers = new int[x];

			for (int i = 0; i < x; i++)
			{
				numbers[i] = int.Parse(val2[i]);
				if (numbers[i] < y)
				{
					sb.Append(val2[i]).Append(" ");
				}
			}

			Console.Write(sb.ToString());
		}
    }
}