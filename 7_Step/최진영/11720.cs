using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();
            int result = 0;
            for(int i =0;i<num.Length;i++)
            {
                result = result + int.Parse(num[i].ToString());
            }
            Console.WriteLine(result);
        }
    }
}
