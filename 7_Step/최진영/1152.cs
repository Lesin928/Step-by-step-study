using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1152
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] aa = a.Split();
            int num = 0;
            for(int i=0;i<aa.Length;i++)
            {
                num++;
                if (aa[i] == "") 
                {
                    num = num - 1;
                }
            }
            Console.WriteLine(num);
        }
    }
}
