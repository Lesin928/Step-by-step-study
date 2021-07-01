using System;

namespace _3단계
{
    class _10950
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);

            for (int i = 0; i < num; i++)
            {
                string a = Console.ReadLine();
                string[] aArr = a.Split();

                Console.WriteLine(int.Parse(aArr[0]) + int.Parse(aArr[1]));
            }
        }
    }
}
