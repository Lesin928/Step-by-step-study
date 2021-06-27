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
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                sum += i;
            }
            WriteLine(sum);
        }
    }
}
