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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                int size = int.Parse(s1[0]);
                int[] arr = new int[size];

                double avg = 0;
                for(int j=0;j<size;j++)
                {
                    arr[j] = int.Parse(s1[j + 1]);
                    avg += arr[j];
                }
                avg /= (double)size;

                double cnt = 0;
                for(int j=0;j<size;j++)
                {
                    if (avg < arr[j])
                        cnt++;
                }

                avg = cnt / (double)size * 100;
                Console.WriteLine("{0:N3}%",avg);
            }
        }
    }
}