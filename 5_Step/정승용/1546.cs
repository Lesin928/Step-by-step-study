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
            float[] arr = new float[a];

            float max = 0;


            string[] st = Console.ReadLine().Split();
            for (int i = 0; i < a; i++) {

                arr[i] = int.Parse(st[i]);

                if (arr[i] > max) {
                    max = arr[i];

                }
            }

            float av = 0;

            for (int j = 0; j < a; j++) {

                arr[j] =(arr[j]/max)*100;
                av += arr[j];
            }

            Console.Write(av/a);


        }
    }
}
