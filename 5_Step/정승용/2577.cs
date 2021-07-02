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

            int[] arr = new int[10];

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int n = a * b * c;
            int num;

            while (n > 0) {
                num = n % 10;
                arr[num]++;
                n /= 10;
            }


            for (int i = 0; i < 10; i++) {
                Console.WriteLine(arr[i]);

            }

        }
    }
}
