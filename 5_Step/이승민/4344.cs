using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준1
{//소수점 반올림 사용 
    class MainProgram
    {
        static void Main(string[] args)
        {
            int C = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();    

            for (int i = 0; i < C; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(a[0]);
                double sum = 0;
                double avr = 0;

                for (int j = 1; j <= n; j++)
                {
                    sum += Convert.ToInt32(a[j]);
                }
                avr = sum / n;
                sum = 0;
                for (int j = 1; j <= n; j++)
                {
                    if(Convert.ToDouble(a[j])>avr)
                    sum += 1;
                }
                sb.Append(string.Format("{0:0.000}",  sum/(double)n*100 )+ "%\n");

            }

            Console.WriteLine(sb);
        }   
    }
}

