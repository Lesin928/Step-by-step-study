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
            string[] s1 = Console.ReadLine().Split(' ');
            int word_cnt = s1.Length;
            int cnt = 0;
            if (s1[0] == "")
                cnt += 1;
            if (s1[word_cnt - 1] == "")
                cnt += 1;
            Console.WriteLine(word_cnt-cnt);
        }
    }
}