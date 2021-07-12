using System;
using static System.Console;
using System.Text;

namespace _4단계
{
    class _1110
    {
        static void Main()
        {
            string inputNum = Console.ReadLine();

            int count = 0;
            int addNum;

            if (10 > int.Parse(inputNum))
            {
                inputNum = inputNum + 0;
            }
            string originalNum = inputNum;

            while (true)
            {
                count++;
                int a = int.Parse(inputNum) / 10;
                int b = int.Parse(inputNum) % 10;
                addNum = a + b;

                inputNum = b.ToString() + (addNum % 10).ToString();


                if (int.Parse(inputNum) == int.Parse(originalNum)) break;
            }
            WriteLine(count);
        }
    }
}
