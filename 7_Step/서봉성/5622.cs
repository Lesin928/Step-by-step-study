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
            string s1 = Console.ReadLine();

            int cnt = 0;
            for(int i=0; i<s1.Length; i++)
            {
                if (s1[i] >= 'A' && s1[i] <= 'C')
                    cnt += 3;
                else if (s1[i] >= 'D' && s1[i] <= 'F')
                    cnt += 4;
                else if (s1[i] >= 'G' && s1[i] <= 'I')
                    cnt += 5;
                else if (s1[i] >= 'J' && s1[i] <= 'L')
                    cnt += 6;
                else if (s1[i] >= 'M' && s1[i] <= 'O')
                    cnt += 7;
                else if (s1[i] >= 'P' && s1[i] <= 'S')
                    cnt += 8;
                else if (s1[i] >= 'T' && s1[i] <= 'V')
                    cnt += 9;
                else if (s1[i] >= 'W' && s1[i] <= 'Z')
                    cnt += 10;
            }
            Console.WriteLine(cnt);

        }
    }
}