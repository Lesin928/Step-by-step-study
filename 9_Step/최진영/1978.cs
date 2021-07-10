using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1978
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            string[] aa = num.Split();
            int[] nums = new int[a];
            int count = 0;
            for(int i=0;i<a;i++)
            {
                nums[i] = int.Parse(aa[i]);
                for(int k=nums[i]-1;k>0;k--)
                {
                    if (k == 1)
                    {
                        count += 1;
                    }
                    else if (nums[i] % k == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
