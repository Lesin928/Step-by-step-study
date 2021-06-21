using System;


namespace _2753
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int year = int.Parse(a[0]);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) Console.WriteLine("1");
            else Console.WriteLine("0");
        }
    }
}
