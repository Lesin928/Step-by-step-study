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
            int j = int.Parse(Console.ReadLine());
            StringBuilder a = new StringBuilder();

            for (int i = 1; i <= j; i++)
            {
                a.Append(i + "\n");

            }
            Console.Write(a);


        }
    }
}