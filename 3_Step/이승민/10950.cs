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
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] ABC = Console.ReadLine().Split(' ');
                int A = Convert.ToInt32(ABC[0]);
                int B = Convert.ToInt32(ABC[1]);

                Console.WriteLine(A+B);

            }


        }
    }
}

