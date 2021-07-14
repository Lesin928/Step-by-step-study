using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            int a = int.Parse(s1[0]);
            int b = int.Parse(s1[1]);
            a = (a % 10 * 100) + (a / 10 % 10 * 10) + (a / 100);
            b = (b % 10 * 100) + (b / 10 % 10 * 10) + (b / 100);
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}