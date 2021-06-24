using System;


namespace _1단계
{
    class _10430
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);

            Console.WriteLine((a + b) % c);
            Console.WriteLine((a % c + b % c) % c);
            Console.WriteLine((a * b) % c);
            Console.WriteLine((a % c * b % c) % c);
        }
    }
}
