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
            string[] AB = Console.ReadLine().Split(' ');
            int min = 1000000, max = -1000000;
            int[] A = new int[AB.Length];

            for (int i = 0; i < AB.Length; i++)
            {
                A[i] = Convert.ToInt32(AB[i]);
                if (A[i] < min)
                {
                    min = A[i];
                }
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            Console.WriteLine("{0} {1}",min,max);
        }   
    }
}

