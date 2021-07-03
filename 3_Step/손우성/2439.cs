using System;
using System.Text;

namespace _3단계
{
    class _2439
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 1; i <= input; i++)
            {
                for (int j = input; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; i > k; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
