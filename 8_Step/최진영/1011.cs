using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for (int k = 0; k < test; k++)
            {
                string a = Console.ReadLine();
                string[] aa = a.Split();
                long start = Convert.ToInt64(aa[0]);
                long end = Convert.ToInt64(aa[1]);
                long distance = end - start;
                long total = 1, turn = 1, range = 0;
                while (total < distance)
                {
                    range++;
                    turn++;
                    total += range;
                    if (total >= distance)
                    {
                        break;
                    }
                    turn++;
                    total += range;
                    if (total >= distance)
                    {
                        break;
                    }
                }
                if (total > distance)
                {
                    turn--;
                }
                Console.WriteLine(turn);
            }
        }
    }
}
