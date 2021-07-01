using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1546
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float[] score= new float[a];
            float[] tscore = new float[a];
            float max=0;
            float aver=0;
            string b = Console.ReadLine();
            string[] bb = b.Split();
            for (int i=0;i<a;i++)
            {
                score[i] = int.Parse(bb[i]);
            }
            max = score[0];
            for(int j=0;j<a;j++)
            {
                if(max<score[j])
                {
                    max = score[j];
                }
            }
            for (int k = 0; k < a; k++)
            {
                tscore[k] = score[k] / max * 100;
            }
            for (int l = 0; l < a; l++)
            {
                aver = aver + tscore[l];
            }
            aver = aver / a;
            Console.WriteLine(aver);
        }
    }
}
