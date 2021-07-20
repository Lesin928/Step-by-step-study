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

            int ABC = Convert.ToInt32(Console.ReadLine());

            if (ABC % 4 == 0 && (ABC % 100 != 0 || ABC % 400 == 0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }


        }
    }
}

