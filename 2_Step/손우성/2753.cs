using System;

namespace _2단계
{
    class _2753
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year < 1 || year > 4000) return;

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Console.WriteLine("1");
            else Console.WriteLine("0");
        }
    }
}
