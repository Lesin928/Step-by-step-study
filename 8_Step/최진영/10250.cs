using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10250
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string a = Console.ReadLine();
                string[] aa = a.Split();
                int floor = int.Parse(aa[0]);
                int num = int.Parse(aa[1]);
                int count = int.Parse(aa[2]);
                int result = 0;
                int k = 0;
                for(int back=1;back<=num;back++)
                {
                    for(int front=1;front<=floor;front++)
                    {
                        k++;
                        if(k==count)
                        {
                            result = front * 100 + back;
                            break;
                            break;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
