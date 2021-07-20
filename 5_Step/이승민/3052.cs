using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] namuge = new int[42];
            int count = 0;
            for (int i = 1; i <= 10; i++)
            {
                a[i-1] = Convert.ToInt32(Console.ReadLine()) % 42;
                namuge[a[i - 1]] += 1;
            }

            for (int i = 0; i < 42; i++)
            {
                if (namuge[i] > 0)
                {
                    count += 1;
                }
            }
            Console.Write(count);

        }   
    }
}

