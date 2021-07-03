using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static bool Seq(int n)
        {
            if (n / 100 == 0)
                return true;

            int n1 = n % 10;
            n /= 10;
            int n2 = n % 10;
            n /= 10;
            int n3 = n;
            if (n1 - n2 == n2 - n3)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 0;
            for(int i=1;i<=n;i++)
            {
                if (Seq(i))
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}