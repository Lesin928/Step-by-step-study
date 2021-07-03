using System;
using System.Text;

namespace _3단계
{
    class _10871
    {
        static void Main(string[] args)
        {
            StringBuilder nums = new StringBuilder();

            string[] input = Console.ReadLine().Split();

            int inputB = int.Parse(input[1]); 

            string[] inputNum = Console.ReadLine().Split();

            foreach (var a in inputNum)
            {
                if (inputB > int.Parse(a))
                {
                    nums.Append(a + " ");
                }
            }
            Console.Write(nums); 
        }
    }
}
