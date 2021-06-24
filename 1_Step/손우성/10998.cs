using System;


namespace _1단계
{
    class _10998
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);

            Console.WriteLine(a * b);
        }
    }
}
