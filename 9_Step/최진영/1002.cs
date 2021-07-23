using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    class Program
    {
		static int posit(int a, int b, int c, int A, int B, int C)
		{
			int result=0;
			if (a == A && b == B && c == C)
			{
				result = -1;
			}
			else if (Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)) < c + C && Math.Abs(c - C) < Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)))
			{
				result = 2;
			}
			else if (Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)) == c + C || Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)) == Math.Abs(c - C))
			{
				result = 1;
			}
			else if (Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)) > c + C || Math.Abs(c - C) > Math.Sqrt(Math.Pow(Math.Abs(a - A), 2) + Math.Pow(Math.Abs(b - B), 2)))
			{
				result = 0;
			}
			return result;
		}
		static void Main(string[] args)
        {
			int test=int.Parse(Console.ReadLine());
			int ends;
			int x1, y1, r1, x2, y2, r2;
			for (int i = 0; i < test; i++)
			{
				string a = Console.ReadLine();
				string[] aa = a.Split();
				x1 = int.Parse(aa[0]);
				y1 = int.Parse(aa[1]);
				r1 = int.Parse(aa[2]);
				x2 = int.Parse(aa[3]);
				y2 = int.Parse(aa[4]);
				r2 = int.Parse(aa[5]);
				ends = posit(x1, y1, r1, x2, y2, r2);
				Console.WriteLine(ends);
			}
		}
    }
}
