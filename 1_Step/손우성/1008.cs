using System;

namespace _1단계
{
    class _1008
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            double a = double.Parse(arr[0]);
            double b = double.Parse(arr[1]);

            Console.WriteLine(a / b);
        }
    }
}
