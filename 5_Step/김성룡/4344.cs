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

            for (int i = 0; i < a; i++)
            {
                string[] s = ReadLine().Split(' ');
                int num = int.Parse(s[0]);
                int[] score = new int[num + 1];
                double sum = 0;
                double avg = 0;
                double count = 0;

                for (int j = 0; j < num + 1; j++)
                {
                    score[j] = int.Parse(s[j]);
                    if (j >= 1)
                    {
                        sum += score[j];
                    }
                }
                avg = sum / num;

                for (int j = 0; j < num + 1; j++)
                {
                    if ((j >= 1) && (score[j] > avg))
                    {
                        count++;
                    }
                }

                double result = count / num;

                WriteLine("{0:#0.000%}", result);

            }
        }
    }
}