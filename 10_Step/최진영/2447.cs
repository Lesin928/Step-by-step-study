using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2447
{
    class Program
    {
        static char[,] map = new char[3000, 3000];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    map[i, j] = ' ';
                }
            }
            FillStar(n, 0, 0);
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    builder.Append(map[i, j]);
                }
                builder.Append("\n");
            }

            Console.WriteLine(builder.ToString());
        }
        static void FillStar(int n, int x, int y)
        {
            if (n == 1)
            {
                map[x, y] = '*';
                return;
            }

            int div = n / 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        continue;
                    }

                    FillStar(div, x + (div * i), y + (div * j));
                }
            }

            return;
        }
    }
}
