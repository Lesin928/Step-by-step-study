using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count =0;
            int a, b, c;


            for (int i = 1;i<=num ;i++)
            {
                a = i / 100;
                b = (i % 100) / 10;
                c = i % 10;

                if (100>i||b-a==c-b) 
                { 
                    count++; 
                        
                }

            }

            Console.WriteLine(count);

        }
    }
}
