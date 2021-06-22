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

            int j = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < j; i++)
            {

                string[] a = Console.ReadLine().Split();

                Console.WriteLine(int.Parse(a[0]) + int.Parse(a[1]));
            }
        }
    }
}
