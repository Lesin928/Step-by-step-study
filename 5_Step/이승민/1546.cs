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
            int N = Convert.ToInt32(Console.ReadLine());

            string[]a = Console.ReadLine().Split(' ');
            double [] s = new double[N];
            int M = 0;
            double sum = 0;

            for (int i = 0; i < N; i++)
            {
                if (Convert.ToInt32(a[i]) > M)
                {
                    M = Convert.ToInt32(a[i]);
                }
            }

            for (int i = 0; i < N; i++)
            {
                s[i] = Convert.ToDouble(a[i]) / M * 100;
                sum += s[i];
            }
            sum = sum / N;
            Console.WriteLine(sum);

        }   
    }
}

