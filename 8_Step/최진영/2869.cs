using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] aa = a.Split();
            int speed = 0, fall = 0, tall = 0;
            int result=0;
            speed = int.Parse(aa[0]);
            fall = int.Parse(aa[1]);
            tall = int.Parse(aa[2]);
            result = (tall - fall - 1) / (speed - fall) + 1;
            Console.WriteLine(result);
        }
    }
}
