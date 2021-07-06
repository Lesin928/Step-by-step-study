using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1712
{
    class Program
    {
        static int calc(int a,int b,int c)
        {
            int fix = 0, change = 0;
            int result;
            if (b >= c)
            {
                result = -1;
                return result;
            }
            else
            {
                fix = c - b;
                change = a / fix;
                result = change + 1;
                return result;
            }
        }
        static void Main(string[] args)
        {
            int first=0, second=0, third=0;
            string num = Console.ReadLine();
            string[] money = num.Split();
            first = int.Parse(money[0]);
            second = int.Parse(money[1]);
            third = int.Parse(money[2]);
            int result = calc(first, second, third);
            Console.WriteLine(result);
        }
    }
}
