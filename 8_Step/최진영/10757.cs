using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10757
{
    class Program
    {
        static void plus(long a,char[] b,char[] c)
        {
            long[] bb = new long[a];
            long[] cc = new long[a];
            for(int k=0;k<a;k++)
            {
                bb[k] = Convert.ToInt32(b[k])-48;
                cc[k] = Convert.ToInt32(c[k])-48;
            }

            long[] result = new long[a+1];
            for (int j = 0; j < a; j++)
            {
                result[j] = result[j] +bb[j] + cc[j];
                if (result[j]>9)
                {
                    result[j] = result[j]- 10;
                    result[j+1] = 1;
                    
                }
            }
            Array.Reverse(result);
            for (int j = 0; j < a+1; j++)
            {
                Console.Write(result[j]);
            }
        }
        static void Main(string[] args)
        {
            long count = 0;
            string a = Console.ReadLine();
            string[] aa = a.Split();
            StringBuilder b = new StringBuilder(aa[0]);
            StringBuilder c = new StringBuilder(aa[1]);
            if (b.Length>= c.Length)
            {
                count = b.Length;
                for (int k = 0; k <= b.Length - c.Length; k++)
                {
                    c.Insert(k,"0");
                }
            }
            else if (b.Length < c.Length)
            {
                count = c.Length;
                for (int k = 0; k <= c.Length - b.Length; k++)
                {
                    b.Insert(k,"0");
                }
            }
            string beta=b.ToString();
            string ceta=c.ToString();

            char[] bb = new char[b.Length];
            bb = beta.ToCharArray();
            char[] cc = new char[c.Length];
            cc = ceta.ToCharArray();
            Array.Reverse(bb);
            Array.Reverse(cc);

            plus(count,bb,cc);
        }
    }
}
