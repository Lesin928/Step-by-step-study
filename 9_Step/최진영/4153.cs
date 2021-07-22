using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4153
{
    class Program
    {
        static void raise(int a, int b, int c)
        {
                if(Math.Pow(a,2)== Math.Pow(b, 2) + Math.Pow(c, 2))
                {
                Console.WriteLine("right");
                }
                else if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                {
                Console.WriteLine("right");
                }
                else if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                {
                Console.WriteLine("right");
                }
                else
                {
                    Console.WriteLine("wrong");
                }
        
        }
        static void Main(string[] args)
        {
            for(int i=0; ;i++)
            {
                string a = Console.ReadLine();
                string[] aa = a.Split();
                int fst = int.Parse(aa[0]);
                int scd = int.Parse(aa[1]);
                int trd = int.Parse(aa[2]);
                if (fst == 0 && scd == 0 && trd == 0)
                {
                    break;
                }
                raise(fst, scd, trd);
            }
        }
    }
}
