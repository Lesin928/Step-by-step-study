using System;
using System.Text;

namespace _3단계
{
    class _2742
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder allNumers = new StringBuilder();

            for (int i = input; i > 0; i--)
            {
                allNumers.Append(i + "\n");
            }
            Console.WriteLine(allNumers);
        }
    }
}
