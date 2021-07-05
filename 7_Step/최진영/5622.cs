using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5622
{
    class Program
    {
        static int change(string word)
        {
            int time = 0;
            int k = 1;
            for(int i=0;i<word.Length;i++)
            {
                if (word[i] == 1)
                {
                    time = time + 2;
                }
                else if(word[i]!=1)
                {
                    for (int a = 'D'; a < 'P'; a+=3)
                    {
                        if (word[i] < a && word[i] >= a - 3)
                        {
                            time = time + k + 2;
                            break;
                        }
                        k++;
                    }
                    if (word[i] >= 'M' && word[i] < 'P')
                    {
                        time = time + k + 2;
                    }
                    else if (word[i] >= 'P' && word[i] < 'T')
                    {
                        k++;
                        time = time + k + 2;
                      
                    }
                    else if (word[i] < 'W' && word[i] >= 'T')
                    {
                        k+=2;
                        time = time + k + 2;
                        
                    }
                    else if (word[i] >= 'W' && word[i] <= 'Z')
                    {
                        k += 3;
                        time = time + k+2;
                    }
                    k = 1;
                }
            }
            return time;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int result = change(a);
            Console.WriteLine(result);
        }
    }
}
