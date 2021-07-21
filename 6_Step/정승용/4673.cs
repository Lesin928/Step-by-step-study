using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234
{
    class Program
    {
        static int MyMethod(int n)
        {

            int num;
            if (n < 10)
            {
                num = n + n;
            }
            else if (n >= 10 && n < 100)
            {
                num = n + (n / 10) + (n % 10);
            }
            else if (n >= 100 && n < 1000)
            {
                num = n + (n / 100) + ((n % 100) / 10) + ((n % 100) % 10);
            }
            else if (n >= 1000 && n < 10000)
            {
                num = n + (n / 1000) + ((n % 1000) / 100) + ((((n % 1000) % 100)) / 10) + ((((n % 1000) % 100)) % 10);
            }
            else
            {
                num = n + 1;
            }

            return num;


        }

        static void Main(string[] args)
        {
            int[] arr = new int[10000];
            StringBuilder sb = new StringBuilder();
            bool tf = true;

            for (int i = 0; i < 10000; i++)
            {
                arr[i] = MyMethod(i);
            }

            for (int i = 0; i <= 10000; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        tf = false;
                        break;
                    }
                    else
                    {
                        tf = true;
                    }
                }

                if (tf == true)
                {
                    sb.AppendLine(i.ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}

