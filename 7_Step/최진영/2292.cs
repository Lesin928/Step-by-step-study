using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            int room = 0;
            int num = int.Parse(Console.ReadLine());
            int change = num-1;
            for (int i = 0; change>6*i; i++)
            {
                if(num==1)
                {
                    room = 0;
                    break;
                }
                change = change - (6 * i);
                room += 1;
            }
            Console.WriteLine(room+1);
        }
    }
}
