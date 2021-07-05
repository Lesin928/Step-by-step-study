using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2908
{
    class Program
    {
        static int pare(int[] ber)
        {
            int final = 0;
            int[] usd = new int[2];
            for(int j=0;j<2;j++)
            {
                usd[j] = (ber[j] % 10) * 100 + (ber[j] % 100/10) * 10 + ber[j] / 100;
            }
            int first = usd[0];
            int second = usd[1];
            if(first>=second)
            {
                final = first;
            }
            else 
            {
                final = second;
            }
            return final;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] hundr = a.Split();
            int[] num = new int[2];
            int result = 0;
            for(int i=0;i<2;i++)
            {
                num[i] = Convert.ToInt32(hundr[i]);
            }
            result = pare(num);
            Console.WriteLine(result);
        }  
    }
}
