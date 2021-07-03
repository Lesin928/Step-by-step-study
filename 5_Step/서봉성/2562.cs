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
            for (int i = 0; i < 9; i++)
            {
                string s1 = Console.ReadLine();
                arr[i] = int.Parse(s1);
            }

            int index = 0, max = arr[0];

            for (int i = 1; i < 9; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(index + 1);
        }
    }
}