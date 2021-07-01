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

            int[] arr = new int[9];

            int num, max;

            for (int j = 0; j < 9; j++)
            {
                arr[j] = int.Parse(Console.ReadLine());
            }

            max = arr[0];
            num = 1;
            for (int i = 1; i < 9; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    num = i+1;
                }

            }

            Console.WriteLine(max);
            Console.WriteLine(num);

        }
    }
}
