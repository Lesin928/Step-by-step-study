using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8958
{
    class Program
    {
		static void Main(string[] args)
		{
			int point = 0;
			int a = int.Parse(Console.ReadLine());
			int[] score = new int[a];
			int v = 0;
			string[] b = new string[a];
			for (int j = 0; j < a; j++)
			{
				b[j] = Console.ReadLine();
			}
			for (int i = 0; i < a; i++)
			{
				char[] bb = b[i].ToCharArray();
				while(true)
				{
					if (bb[v] == 'O')
					{
						point++;
						score[i] = score[i] + point;
					}
					else
					{
						point = 0;
					}
					v++;
					if(v==bb.Length)
                    {
						point = 0;
						v = 0;
						break;
                    }
				}
			}
			for (int k = 0; k < a; k++)
			{
				Console.WriteLine(score[k]);
			}
		}
    }
}
