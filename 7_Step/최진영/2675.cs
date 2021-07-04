using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string b = Console.ReadLine();
                int count;
                count=b[0]-48;
                for (int j = 2;j<b.Length; j++)
                {
                    
                    char[] sent = new char[b.Length];
                    sent[j-2] = b[j];
                    for (int k = 0; k < count; k++)
                    {
                        Console.Write(sent[j-2]);
                    }
                    
                }
                Console.WriteLine();
            }   
        }
    }
}