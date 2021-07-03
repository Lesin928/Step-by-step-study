using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int a = int.Parse(ReadLine());
            string s;
            int cnt = 0;
            int sum = 0;

            for (int i = 0; i < a; i++)
            {
                s = ReadLine();
                foreach (char b in s)
                {
                    if (b == 'O')
                    {
                        cnt++;
                        sum += cnt;
                    }
                    else
                    {
                        cnt = 0;
                    }
                }
                WriteLine(sum);
                cnt = 0;
                sum = 0;
            }
        }
    }
}
