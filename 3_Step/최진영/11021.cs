using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11021
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder nums = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                string s = Console.ReadLine();
                string[] v = s.Split();
                int first = int.Parse(v[0]);
                int second = int.Parse(v[1]);
                nums.Append("Case #"+(i+1)+": "+ (first + second) + "\n");
            }
            Console.WriteLine(nums.ToString());
        }
    }
}
