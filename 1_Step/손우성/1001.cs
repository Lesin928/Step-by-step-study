using System;

namespace _1단계
{
    class _1001
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] arr_input = input.Split();

            Console.WriteLine(int.Parse(arr_input[0]) - int.Parse(arr_input[1]));
        }
    }
}
