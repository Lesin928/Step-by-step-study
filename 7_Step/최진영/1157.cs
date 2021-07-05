using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
			char[] word=new char[1000000];
			Array.Clear(word, 0, 1000000);
			int[] count = new int[91];
			Array.Clear(count, 0, 91);
			int result=0;
			string s = Console.ReadLine();
			for(int i=0;i<s.Length;i++)
            {
				word[i] = s[i];
            }
			for (int w = 0;w<1000000 ; w++)
			{
				if (word[w] > 96)
				{
					word[w] = Convert.ToChar(word[w] - 32);
				}
				else if (word[w] == 0)
				{
					break;
				}
			}

			for (int v = 0;v<1000000 ; v++)
			{
				if (word[v] == 0)
				{
					break;
				}
				count[word[v]] += 1;
			}

			for (int t = 65; t < 91; t++)
			{
				if (count[t] > count[t - 1])
				{
					result = t;
				}
				else if (count[t] < count[t - 1])
				{
					count[t] = count[t - 1];
				}
				else if (count[t] == count[t - 1])
				{
					result = 63;
				}
			}
			Console.WriteLine((char)result);
		}
    }
}
