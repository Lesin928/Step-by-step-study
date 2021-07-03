using System;
using System.Text;

namespace _3단계
{
    class _11021
    {
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] aAndB = Console.ReadLine().Split();
                a[i] = int.Parse(aAndB[0]);
                b[i] = int.Parse(aAndB[1]);
            }

            StringBuilder Output = new StringBuilder();

            for (int i = 0; i < t; i++)
            {
                int aPlusB = a[i] + b[i];
                Output.Append("Case #" + (i + 1) + ": ").Append(aPlusB).Append("\n");
            }

            Console.Write(Output.ToString());
        }
    }
}
