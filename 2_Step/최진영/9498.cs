using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9498
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= int.Parse(Console.ReadLine());
            if(a<=100&&a>=90)
            {
                Console.WriteLine("A");
            }
            else if(a<90&&a>=80)
            {
                Console.WriteLine("B");
            }
            else if (a < 80 && a >= 70)
            {
                Console.WriteLine("C");
            }
            else if (a < 70 && a >= 60)
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
