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
            for (int i = 1; i <= 9 ; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",N,i,i*N);
            }
        }
    }
}

