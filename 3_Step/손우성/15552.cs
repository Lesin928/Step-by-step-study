using System;
using System.Text;
using System.IO;

namespace _3단계
{
    class _15552
    {
        static void Main(string[] args)
        {
            int maxT = int.Parse(Console.ReadLine());
            int[] aNum = new int[maxT];
            int[] bNum = new int[maxT];
            StringBuilder abNumbers = new StringBuilder();

            for (int i = 0; i < maxT; i++)
            {
                string[] ab = Console.ReadLine().Split();
                aNum[i] = int.Parse(ab[0]);
                bNum[i] = int.Parse(ab[1]);
                abNumbers.Append(aNum[i] + bNum[i] + "\n");

            }
            Console.WriteLine(abNumbers.ToString());
        }
    }
}
//모르겠어서 구글링해서 그대로 배꼈습니다...ㅠ