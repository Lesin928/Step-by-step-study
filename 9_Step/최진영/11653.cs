using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11653
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for(int i =2;i<=a;i++)
            {
                if(a%i==0)
                {
                    a = a / i;
                    Console.WriteLine(i);
                    i = 1;
                }
                else if(a==1)
                {
                    break;
                }
            }
        }
    }
}
