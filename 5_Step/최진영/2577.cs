using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2577
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int length,rest, max,k;
            int result = a * b * c;
            int[] count = new int[10];
            for(length=0; ; length++)
            {
                if(Math.Pow(10,length)>=result)
                {
                    break;
                }
            }
            for (k = length - 1; k >= 0; k--)
            {
                max = (int)Math.Pow(10, k);
                rest = result / max;
                result = result % max;
                count[rest] = count[rest] + 1;
            }
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("{0}",count[i]);
            }
        }
    }
}
