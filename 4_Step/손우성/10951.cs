using System;
using static System.Console;
using System.Text;

namespace _4단계
{
    class _10951
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] inputNum = input.Split();
                int numA = int.Parse(inputNum[0]);
                int numB = int.Parse(inputNum[1]);
                int addNum = numA + numB;
                WriteLine(addNum);
            }
        }
    }
}
