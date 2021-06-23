using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            int time, min;
            string c = Console.ReadLine();
            string[] s = c.Split();
            time = int.Parse(s[0]);
            min = int.Parse(s[1]);
            min = min - 45;
            if(min<0)
            {
                min = min + 60;
                time = time - 1;
            }
            if(time<0)
            {
                time = time + 23;
            }
            Console.WriteLine("{0} {1}", time, min);
        }
    }
}
