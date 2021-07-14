using System;

namespace _4단계
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string[] input = Console.ReadLine().Split();
                int numA = int.Parse(input[0]);
                int numB = int.Parse(input[1]);
                int addNum = numA + numB;

                if (numA == 0 && numB == 0)
                {
                    break;
                }
                Console.WriteLine(addNum);

            }
        }
    }
}