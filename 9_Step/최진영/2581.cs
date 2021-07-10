using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2581
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int count = 0;
            int[] nums = new int[high - low+1];
            int many = 0;
            for (int i = low; i <= high; i++)
            {
                for (int k = i - 1; k > 0; k--)
                {
                    if (k == 1)
                    {
                        count += i;
                        nums[many] = i;
                        many++;
                    }
                    else if (i % k == 0)
                    {
                        break;
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine(-1);
            }
            else 
            {
                Console.WriteLine(count);
                Console.WriteLine(nums[0]);
            }
            
        }
    }
}
