using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string[] s1 = Console.ReadLine().Split(' ');
                int cnt = int.Parse(s1[0]);
                for(int j=0;j<s1[1].Length;j++)
                {
                    int a = 0;
                    while (a < cnt)
                    {
                        Console.Write(s1[1][j]);
                        a += 1;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}