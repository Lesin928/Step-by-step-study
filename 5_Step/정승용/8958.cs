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

            int sum = 0;
            int count = 0;
            int n = int.Parse(Console.ReadLine());

            string st;

       
            for (int i = 0; i < n; i++)
            {
                st = Console.ReadLine();
                foreach (char a in st)
                {
                    if (a == 'O')
                    {
                        count++;
                        sum += count;
                    }
                    else
                        count = 0;
                }
                Console.WriteLine(sum);

                sum = 0;
                count = 0;

            }


        }
    }
}
