using System;

namespace _2단계
{
    class _2884
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split(' ');

            int hour = int.Parse(args[0]);
            int min = int.Parse(args[1]);

            if (min < 45)
            {
                hour -= 1;
                min += 60;
            }

            if (hour < 0)
            {
                hour += 24;
            }

            min -= 45;

            Console.WriteLine($"{hour} {min}");
        }
    }
}
