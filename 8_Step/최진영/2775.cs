using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2775
{
    class Program
    {
        static int resid(int a, int b)
        {
            int count = 0;
            int[,] d = new int[15,15];
            for (int i = 1; i < 15; i++)
            {
                d[0,i] = i;
            }
            for (int i = 1; i < 15; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    d[i,j] = d[i - 1,j] + d[i,j - 1];
                }
            }
            count = d[a,b];
            return count;
        } 
        static void Main(string[] args)
        {
            
            int cnum = int.Parse(Console.ReadLine());
            int[] result = new int[cnum];
            for(int i=0;i<cnum;i++)
            {
                int floor = int.Parse(Console.ReadLine());
                int room = int.Parse(Console.ReadLine());
                result[i] = resid(floor, room);
            }
            for(int i = 0; i < cnum; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
