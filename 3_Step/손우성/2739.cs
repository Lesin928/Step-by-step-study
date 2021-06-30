using System;

namespace _3단계
{
    class _2739
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(s + " * " + i + " = " + int.Parse(s) * i);
            }
        }
    }
}
