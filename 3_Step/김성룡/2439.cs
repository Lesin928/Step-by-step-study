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

            for (int i = 0; i < a; i++)
            {
                for (int j = a - 1; j > i; j--)
                {
                    Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
