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
            int[] arr = new int[26];

            for (int i = 0; i < 26; i++)
                arr[i] = -1;

            for(int i=0;i<s1.Length;i++)
            {
                int index = s1[i] - 'a';
                if (arr[index] != -1)
                    continue;
                else
                    arr[index] = i;
            }

            for (int i = 0; i < 26; i++)
                Console.Write("{0} ", arr[i]);
        }
    }
}