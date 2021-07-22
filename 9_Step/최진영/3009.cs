using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3009
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            int[] y = new int[3];
            int resultx=0, resulty=0;
            for(int i=0;i<3;i++)
            {
                string a = Console.ReadLine();
                string[] aa = a.Split();
                x[i] = int.Parse(aa[0]);
                y[i] = int.Parse(aa[1]);
            }
            for(int j=1;j<3;j++)
            {
                if(x[0]!=x[j])
                {
                    resultx = x[j];
                    if(x[1]==x[2])
                    {
                        resultx = x[0];
                    }
                }
                if (y[0] != y[j])
                {
                    resulty = y[j];
                    if (y[1] == y[2])
                    {
                        resulty = y[0];
                    }
                }
            }
            Console.WriteLine("{0} {1}", resultx, resulty);
        }
    }
}
