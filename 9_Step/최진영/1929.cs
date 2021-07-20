using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = Console.ReadLine();
            string[] num = nums.Split();
            int low = int.Parse(num[0]);
            int high = int.Parse(num[1]);
            int number = high-low;
            int[] a = new int[number+1];
            int k =0;
            for (int i = low; i <= high; i++)
            {
                a[k] = i;
                k++;
            }


            for (k = 2; k <= number; k++)
            {
                for (int j = 2 * k; j <= high; j += k)
                {
                    for (int l = 0; l < number; l++)
                    {
                        
                        if (a[l] == 0)
                        {
                            Console.WriteLine(j);
                            continue;
                        }
                        else if (a[l] % j == 0)
                        {
                            a[l] = 0;
                        }

                    }

                }
            }
            for (int i = 0; i < number; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine(a[i]);
                }
            }

        }
    }
}
