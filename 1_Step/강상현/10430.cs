using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000000022222222
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            string[] cc = d.Split();
            int a = int.Parse(cc[0]);
            int b = int.Parse(cc[1]);
            int c = int.Parse(cc[2]);
            Console.WriteLine((a+b)%c);
            Console.WriteLine(((a%c)+(b%c))%c);
            Console.WriteLine((a*b)%c);
            Console.WriteLine(((a%c)*(b%c))%c);
        }
    }
}