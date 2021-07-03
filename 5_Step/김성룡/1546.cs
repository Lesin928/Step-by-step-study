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
            string[] s = ReadLine().Split(' ');
            double[] b = new double[a];
            double max = b[0];
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] > max)
                {
                    max = b[i];
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] / max * 100;
            }
            for (int i = 0; i < b.Length; i++)
            {
                sum += b[i];
            }
            avg = sum / b.Length;
            WriteLine(avg);
        }
    }
}
