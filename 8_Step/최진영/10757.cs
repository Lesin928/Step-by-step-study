using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10757
{
    class Program
    {
        static void plus(char[] b,char[] c)
        {
            
            int count = 0;
            Console.WriteLine(b.Length);
            Console.WriteLine(c.Length);
            if (b.Length >= c.Length)
            {
                count = b.Length;
                Array.Resize(ref c, b.Length);
                Console.WriteLine(c.Length);
                for (int k = 0; k < b.Length - c.Length; k++)
                {
                    c[c.Length-k]='0';
                }
                Console.WriteLine(c);
            }
            else if(b.Length<c.Length)
            {
                count = c.Length;
                Array.Resize(ref b, c.Length);
                Console.WriteLine(b.Length);
                for (int k = 0; k < c.Length - b.Length; k++)
                {
                    b[b.Length - k] = '0';
                }
                Console.WriteLine(c);
            }
            int[] result = new int[count + 1];
            for (int j = 0; j < count; j++)
            {
                result[j] = result[j] +(Convert.ToInt32(b[j])-48) + (Convert.ToInt32(c[j])-48);
                if (result[j]>9)
                {
                    result[j] = result[j]- 10;
                    result[j+1] = 1;
                    Console.WriteLine(j);
                    Console.WriteLine(result[j]);
                    Console.WriteLine(result[j+1]);
                }
            }
            Array.Reverse(result);
            for (int j = 0; j < count+1; j++)
            {
                Console.Write(result[j]);
            }
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] aa = a.Split();
            char[] b = new char[10002];
            b= aa[0].ToCharArray();
            char[] c = new char[10002]; 
            c= aa[1].ToCharArray();
            Array.Reverse(b);
            Array.Reverse(c);
            plus(b, c);
        }
    }
}
