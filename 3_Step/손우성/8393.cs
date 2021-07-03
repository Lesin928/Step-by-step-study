using System;

namespace _3단계
{
    class _8393
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            int addNum = 0;

            for (int i = 1; i <= num; i++)
            {
                addNum += i;
            }
            Console.WriteLine(addNum);
        }
    }
}
