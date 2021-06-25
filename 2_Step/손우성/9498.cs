using System;

namespace _2단계
{
    class _9498
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(input);
            if (100 >= num && 90 <= num)
            {
                Console.WriteLine("A");
            }
            else if (89 >= num && 80 <= num)
            {
                Console.WriteLine("B");
            }
            else if (79 >= num && 70 <= num)
            {
                Console.WriteLine("C");
            }
            else if (69 >= num && 60 <= num)
            {
                Console.WriteLine("D");
            }
            else
                Console.WriteLine("F");
        }
    }
}
