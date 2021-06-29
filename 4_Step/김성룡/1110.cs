using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            int result = a;
            int cnt = 0;
            while(a!=result)
            {
                cnt++;
                int b = a / 10;
                int c = a % 10;
                a = (c * 10) + ((b + c)%10);
            }
            WriteLine(cnt);
        }
    }
}
