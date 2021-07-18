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

            if (ABC>=90 && ABC<=100 )
            {
                Console.WriteLine("A");
            }
            else if (ABC >= 80 && ABC <= 89)
            {
                Console.WriteLine("B");
            }
            else if (ABC >= 70 && ABC <= 79)
            {
                Console.WriteLine("C");
            }
            else if (ABC >= 60 && ABC <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }





        }
    }
}

