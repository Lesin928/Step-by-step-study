using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2941
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int d = 0;
            string a = Console.ReadLine();
            char[] croat = a.ToCharArray();
            for(int i=0;i<croat.Length;i++)
            {
                count++;
                if (croat[i] == '=')
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else if (i == 1)
                    {
                        if (croat[i - 1] == 'c' || croat[i-1] == 's' || croat[i-1] == 'z')
                        {
                            d++;
                        }
                    }
                    else if (i > 1)
                    {
                        if (croat[i - 1] == 'z' && croat[i - 2] == 'd')
                        {
                            d = d + 2;
                        }
                        else if (croat[i - 1] == 'c' || croat[i-1] == 's' || croat[i-1] == 'z')
                        {
                            d++;
                        }
                        
                    }
                }
                else if (croat[i] == '-')
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else if (i >= 1)
                    {
                        if (croat[i - 1] == 'c' || croat[i-1] == 'd')
                        {
                            d++;
                        }
                    }
                }
                else if (croat[i] == 'j' )
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else if (i >= 1)
                    {
                        if (croat[i - 1] == 'l' || croat[i-1] == 'n')
                        {
                            d++;
                        }
                    }
                }
            }
            Console.WriteLine(count-d);
        }
    }
}
