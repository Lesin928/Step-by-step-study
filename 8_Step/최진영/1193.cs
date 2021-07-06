using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1193
{
    class Program
    {
        static void fract(int a)
		{
			int k = 1;
			int mother = 1, son = 1;
			for (int i = 1; ; i++)
			{
				if (mother > son)
				{
					mother = mother + 1;
					for (int j = 0; mother > 1; j++)
					{

						mother = mother - 1;
						if (k == a)
						{
							break;
						}
						son = son + 1;
						k++;

					}
				}
				else if (mother <= son)
				{
					son = son + 1;
					for (int l = 0; son > 1; l++)
					{


						son = son - 1;
						if (k == a)
						{
							break;
						}
						mother = mother + 1;
						k++;

					}
				}
				if (k == a)
				{
					break;
				}
			}
			Console.WriteLine("{0}/{1}", son, mother);
		}
		static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            
            fract(count);
        }
    }
}
