using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static int Self(int n)
        {
            int res = n;
            while(n>0)
            {
                res += n % 10;
                n /= 10;
            }
            return res;
        }


        static void Main(string[] args)
        {
            bool[] arr = new bool[10040];
            for(int i=1;i<10000;i++)
            {
                arr[Self(i)] = true;

                if (arr[i])
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}