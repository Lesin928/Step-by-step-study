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
            int[] a = new int[9];
            int count = 0;
            int max = 0;
            a[0] = 0;
            for (int i = 1; i <= 9; i++)
            {
                a[i-1] = Convert.ToInt32(Console.ReadLine());
                if(max < a[i-1])
                {
                    max = a[i-1];
                    count = i;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(count);


        }   
    }
}

