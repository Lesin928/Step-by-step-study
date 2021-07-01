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
            int[] arr = new int[a];
            int max, min;
            string[] val = Console.ReadLine().Split();

            for (int j = 0; j < a; j++)
            {
                arr[j] = int.Parse(val[j]);
            }

            min = arr[0];
            max = arr[0];

            for (int i = 1; i < a; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

        Console.WriteLine("{0} {1}", min,max);

        }
    }
}
