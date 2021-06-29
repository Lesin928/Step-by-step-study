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
            while (true) {

                string st = Console.ReadLine();
                if (st == null)
                {
                    break;
                }
                string[] num = st.Split();
                int a = int.Parse(num[0]);
                int b = int.Parse(num[1]);
                Console.WriteLine(a+b);
            }
		}
    }
}