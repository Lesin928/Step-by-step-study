using System;
using System.Text;

namespace _3단계
{
    class _2438
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
