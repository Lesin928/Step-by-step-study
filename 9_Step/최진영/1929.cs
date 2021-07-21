using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            string[] num = nums.Split();
            int low = int.Parse(num[0]);
            int high = int.Parse(num[1]);
            int[] a = new int[1000001];
            for (int i = 2; i <= high; i++)
            {
                for (int j = 2; i * j <=high; j++)
                {
                    a[i * j] = 1;
                }
            }
            a[1] = 1;
            for (int k = low; k <= high; k++)
            {
                if (a[k]==0)
                {
                    result.Append(k+"\n");
                }
            }
            Console.Write(result.ToString());
        }
    }
}
