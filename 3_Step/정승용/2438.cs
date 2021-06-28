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
            int val = int.Parse(Console.ReadLine());

            for (int i = 0; i < val; i++) {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }
        }
    }
}