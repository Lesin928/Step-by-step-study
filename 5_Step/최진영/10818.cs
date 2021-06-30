using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            int a = int.Parse(Console.ReadLine());
            string[] inside = Console.ReadLine().Split();
            int[] num = new int[a];
            for (int i = 0; i < a; i++)
            {
                num[i] = int.Parse(inside[i]);
            }
            min = num[0];
            max = num[0];
            for (int j = 1; j < a; j++)
            {
                if (max <= num[j])
                {
                    max = num[j];
                }
                else if (min >= num[j])
                {
                    min = num[j];
                }
            }
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
