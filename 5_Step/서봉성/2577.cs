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
            int val = 1;
            int[] cnt_num = new int[10];

            for (int i = 0; i < 3; i++)
            {
                string s1 = Console.ReadLine();
                val *= int.Parse(s1);
            }

            while(val>0)
            {
                cnt_num[val % 10] += 1;
                val /= 10;
            }

            for(int i=0;i<10;i++)
            {
                Console.WriteLine(cnt_num[i]);
            }
        }
    }
}