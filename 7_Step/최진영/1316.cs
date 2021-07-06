using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1316
{
    class Program
    {
        static int check(string compare)
        {
            int count = 1;
            for (int j = 0; j < compare.Length; j++)
            {
                for (int k = 1; k < compare.Length; k++)
                {
                    if (k-j>1)
                    {
                        if(compare[k]==compare[j])
                        {
                            count = 0;
                        }
                    }
                    if(compare[k]==compare[j])
                    {
                        j = j + (k - j);
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int result = 0;
            int a = int.Parse(Console.ReadLine());
            int[] num = new int[a];
            string[] word = new string[a];
            for (int i=0;i<a;i++)
            {
                word[i] = Console.ReadLine();
                num[i] = check(word[i]);
            }
            for(int l=0; l<a;l++)
            {
                result = result + num[l];
            }
            Console.WriteLine(result);
        }
    }
}
