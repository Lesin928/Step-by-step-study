using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4673
{
    class Program
    {
        static void Main(string[] args)
        {
			int count;
			int[] first = new int[10001];
			for (int i = 1; ; i++)
			{
				count = use(i);
				first[count] = 1;
				if (count >= 10000)
				{
					break;
				}
			}
			for (int j = 1; ; j++)
			{
				if (first[j] == 0)
				{
					Console.WriteLine(j);
					if (j >= 9993)
					{
						break;
					}
				}
			}
		}

		static int use(int last)
		{
			int num = 1;
			if (last < 10)
			{
				num = last + last;
			}
			else if (last >= 10 && last < 100)
			{
				num = last + last % 10 + last / 10;
			}
			else if (last >= 100 && last < 1000)
			{
				num = last + last / 100 + (last % 100) / 10 + (last % 100) % 10;
			}
			else if (last >= 1000 && last < 10000)
			{
				num = last + last / 1000 + (last % 1000) / 100 + ((last % 1000) % 100) / 10 + ((last % 1000) % 100) % 10;
			}
			return num;
		}
	}
}
