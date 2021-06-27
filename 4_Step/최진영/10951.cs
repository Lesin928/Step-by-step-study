using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            while(true)
            {
                string s = Console.ReadLine();
                if (s == null)
                {
                    break;
                }
                string[] v = s.Split();
                int first = int.Parse(v[0]);
                int second = int.Parse(v[1]);
                Console.WriteLine(first + second);
            }
            
        }
    }
}
