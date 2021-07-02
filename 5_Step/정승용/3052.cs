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

            int max = 10;
            int div = 42;

            int r = 0;
            bool[] tf = new bool[div];

            for (int i = 0; i < max; i++)
            {
                r = int.Parse(Console.ReadLine()) % div;
                tf[r] = true;
            }

            int count = 0;
            for (int i = 0; i < tf.Length; i++)
            {
                if (tf[i]) count++;
            }

            Console.WriteLine(count);

        }
    }
}
