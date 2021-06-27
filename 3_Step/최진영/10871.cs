using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            string goal = Console.ReadLine();
            string[] gg = goal.Split();
            n = int.Parse(gg[0]);
            a = int.Parse(gg[1]);
            string num = Console.ReadLine();
            string[] nums = num.Split();
            StringBuilder alpha = new StringBuilder();
            for(int i=0; i<n;i++)
            {
                if(int.Parse(nums[i]) < a)
                {
                    alpha.Append(nums[i]+" ");
                }
            }
            Console.WriteLine(alpha.ToString());
        }
    }
}
