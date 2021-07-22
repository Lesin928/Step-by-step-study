using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1085
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] so = a.Split();
            int x, y, w, h;
            x = int.Parse(so[0]);
            y = int.Parse(so[1]);
            w= int.Parse(so[2]);
            h = int.Parse(so[3]);
            int right= w - x;
            int left = x;
            int up = h- y;
            int down = y;
            int range, height;
            range = right > left ? left : right;
            height = up > down ? down : up;
            if (range<height)
            {
                Console.WriteLine(range);
            }
            else if(range>=height)
            {
                Console.WriteLine(height);
            }
        }
    }
}
