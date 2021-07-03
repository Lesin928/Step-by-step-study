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
            bool[] arr = new bool[42];

            for(int i=0;i<10;i++)
            {
                int n = int.Parse(Console.ReadLine());
                arr[n % 42] = true;
            }

            int count = 0;
            for(int i=0;i<42;i++)
            {
                if (arr[i])
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}