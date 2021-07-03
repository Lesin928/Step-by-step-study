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
                string s1 = Console.ReadLine();
                int count = 1, val = 0;
                for (int j = 0; j < s1.Length; j++)
                {
                    if (s1[j] == 'O')
                        val += count++;
                    else
                        count = 1;
                }
                Console.WriteLine(val);
            }
        }
    }
}