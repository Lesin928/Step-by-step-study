using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11729
{
	
	class Program
	{
		static StringBuilder result = new StringBuilder();
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			Console.WriteLine(Math.Pow(2, size) - 1);
			move(size, 1, 2, 3);
			Console.WriteLine(result);
		}
		static void move(int a, int A, int B, int C)
		{
			
			if (a == 0)
			{
				return;
			}
			else
			{
				move(a - 1, A, C, B);
				result.Append(A + " " + C + "\n");
				move(a - 1, B, A, C);
			}
		}
	}
}

