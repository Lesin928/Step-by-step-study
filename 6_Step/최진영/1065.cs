using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
		static void Main(string[] args)
		{
			int count;
			int goal = int.Parse(Console.ReadLine());
			count = use(goal);
			Console.WriteLine(count);
		}
		static int use(int last)
		{
			int num = 1;
			for(int i=2;i<=last;i++)
            {
				int hund, ten, one;
				hund = i / 100;
				ten = (i % 100) / 10;
				one = (i % 100) % 10;
				if (i<100)
                {
					num++;
                }
				else if(hund-ten==ten-one)
                {
					num++;
                }
            }
			return num;
		}
    }
}
