using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2839
{
    class Program
    {
        static int five(int A)
        {
            int count = A/5;
            return count;
        }
        static int three(int B)
        {
            int ends = 0;
            if (B % 3 != 0)
            {
                ends = -1;
            }
            else if(B % 3 == 0)
            {
                ends = B / 3;
            }
            return ends;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int result = five(a);
            int rest = 0;
            int other = 0;
            if (result == 0)
            {
                result = three(a);
            }
            else if (a == 7)
            {
                result = -1;
            }
            else
            {
                rest = a % 5;
            }
            if (rest == 1)
            {
                result = result - 1;
                rest = 6;
            }
            else if(rest == 2)
            {
                result = result - 2;
                rest = 12;
            }
            else if(rest == 4)
            {
                result = result - 1;
                rest = 9;
            }
            if (rest != 0)
            {
                other = three(rest);
            }
            if (other == -1)
            {
                result = other;
            }
            else if(other != -1)
            {
                result = result + other;
            }
            Console.WriteLine(result);
        }
    }
}
