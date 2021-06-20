using System;

namespace _1330
{
    class Program
    {
        static void Main(string[] args)
        {
            string []a = Console.ReadLine().Split();
            int i = int.Parse(a[0]);
            int j = int.Parse(a[1]);

            if (i > j)
            {
                Console.WriteLine(">");
            }
            else if (i < j)
            {
                Console.WriteLine("<");
            }
            else {
                Console.WriteLine("==");
            }
        }
    }
}
