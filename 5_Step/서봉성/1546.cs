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
            string[] s1 = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            int max = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(s1[i]);
                if (max < arr[i])
                    max = arr[i];
            }
            
            double score = 0;
            for(int i=0;i<n;i++)
            {
                score += ((double)arr[i] / max) * 100;
            }

            Console.WriteLine(score / n);  
        }
    }
}