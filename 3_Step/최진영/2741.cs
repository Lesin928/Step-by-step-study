using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2741
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                int num = i;
                result.Append(num + "\n");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
