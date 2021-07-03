using System;
using System.Text;

namespace _3단계
{
    class _2741
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder allNumbers = new StringBuilder();

            for (int i = 1; i < n + 1; i++)
            {
                int number = n - (n - i);
                allNumbers.Append(number + "\n");
            }
            Console.Write(allNumbers.ToString());
        }
    }
}
