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
            int[] alphabet = new int[26];
            for(int i=0;i<s1.Length;i++)
            {
                if (s1[i] < 'a')
                    alphabet[s1[i] - 'A'] += 1;
                else
                    alphabet[s1[i] - 'a'] += 1;
            }

            int max = 0;
            int index = 0;
            for(int i=0;i<26;i++)
            {
                if (max < alphabet[i])
                {
                    max = alphabet[i];
                    index = i;
                }
            }
            for(int i=0;i<26;i++)
            {
                if (i == index)
                    continue;
                else if(max==alphabet[i])
                {
                    Console.WriteLine("?");
                    return;
                }
            }
            Console.WriteLine(Convert.ToChar(index + 'A'));
        }
    }
}