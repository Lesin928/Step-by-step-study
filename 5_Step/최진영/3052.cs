using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[10];
            int[] rest = new int[42];
            int divide,result=0;
            for (int i = 0;i<=9 ; i++)
            {
                count[i] = int.Parse(Console.ReadLine());
            }
            for(int j=0;j<=9;j++)
            {
                divide = count[j] % 42;
                rest[divide] = rest[divide] + 1;
            }
            for(int k=0;k<42;k++)
            {
                if(rest[k]>0)
                {
                    result = result + 1;
                }
            }
            Console.WriteLine(result);
        }
    }
}