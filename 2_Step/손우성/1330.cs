using System;

namespace _2단계
{
    class _1330
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int number1 = int.Parse(numbers[0]);
            int number2 = int.Parse(numbers[1]);

            if (number1 > number2)
            {
                Console.WriteLine(">");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
