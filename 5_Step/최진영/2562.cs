using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2526
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, maxnum;
            int[] num = new int[9];
            for (int i = 0; i < 9; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            max = 1;
            maxnum = num[0];
            for (int j = 1; j < 9; j++)
            {
                if (maxnum <= num[j])
                {
                    maxnum = num[j];
                    max = j+1;
                }
            }
            Console.WriteLine("{0}\n{1}", maxnum, max);
        }
    }
}
