using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9020
{
    class Program
    {
        static void calc(int num)
        {
            StringBuilder result = new StringBuilder();
            int alpha;
            int re1=0, re2=0;
            int r=0;
            int[] final = new int[num+1];
            int[] ex = new int[num+1];
            for(int i=2;i<num;i++)
            {
                for(int j=i+i;j<num;j+=i)
                {
                    ex[j] = 1;
                }
            }
            ex[1] = 1;
            for (int k = 1; k <= num; k++)
            {
                if (ex[k] == 0)
                {
                    final[r] = k;
                    r++;
                }
                
            }
            Array.Resize(ref final, r);
            for (int i=0;i<final.Length; i++)
            {
                for(int j=i;j< final.Length; j++)
                {
                    alpha = final[i] + final[j];
                    if (alpha != num || final[i] > final[j])
                    {
                        continue;
                    }
                        re1 = final[i];
                        re2 = final[j];
                }
            }
            result.Append(re1 + " " + re2 + "\n");
            Console.Write(result.ToString());
        }
        static void Main(string[] args)
        {
            int many = int.Parse(Console.ReadLine());
            for (int k=0;k<many;k++)
            {
                int num = int.Parse(Console.ReadLine());
                calc(num);
            }
        }
    }
}


