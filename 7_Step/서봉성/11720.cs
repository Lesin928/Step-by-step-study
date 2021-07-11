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
            string s1 = Console.ReadLine();
            int sum = 0;
            
            for(int i=0;i<n;i++)
            {
                sum += int.Parse(s1[i].ToString());
            }

            Console.Write(sum);
        }
    }
}