using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4948
{
    class Program
    {
        static int calc(int a)
        {
            int low = a;
            int high = a * 2;
            int count = 0;
            int[] nums = new int[246913];

            for (int i = 2; i <= high; i++)
            {
                for (int j = 2; i * j <= high; j++)
                {
                    nums[i * j] = 1;
                }
            }
            nums[1] = 1;
            for (int k = low+1; k <= high; k++)
            {
                if (nums[k] == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int num;
            int result;
            StringBuilder so = new StringBuilder();
            for (int i=0; ;i++)
            {
                num=int.Parse(Console.ReadLine());
                if(num==0)
                {
                    break;
                }
                result = calc(num);
                so.Append(result + "\n");
            }
            Console.Write(so.ToString());
        }
    }
}

