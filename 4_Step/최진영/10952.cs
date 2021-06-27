using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            StringBuilder answer = new StringBuilder();
            while (i > -1 )
            {
                string s = Console.ReadLine();
                string[] v = s.Split();
                int first = int.Parse(v[0]);
                int second = int.Parse(v[1]);
                if(first ==0 && second == 0)
                {
                    break;
                }
                answer.Append(first + second + "\n");
                i++;
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
