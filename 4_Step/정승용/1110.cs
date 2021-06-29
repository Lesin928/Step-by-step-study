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
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            int count = 0;

            while (b!= a) {
                if (b == 0){ b = a; }
                count++;
                b = 10 * (b % 10) + ((b / 10) + (b % 10)) % 10;
            }
            if (b == 0) {
                Console.WriteLine(1);
            } else { 
                Console.WriteLine(count); 
            }
        }
    }
}