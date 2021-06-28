using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c10950
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <=b; i++)
            {
                a += i;


            }
            Console.WriteLine(a);

        }
    }
}
