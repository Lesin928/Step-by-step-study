using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10809
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int[] apb = new int[26];
            apb = Enumerable.Repeat(-1, 27).ToArray();
            for(int i=0;i<a.Length;i++)
            {
                char letter = a[i];
                int posit = Convert.ToInt32(letter);
                if (apb[posit - 97] == -1)
                {
                    apb[posit - 97] = i;
                }
            }
            for(int j=0;j<26;j++)
            {
                Console.Write(apb[j]);
                Console.Write(" ");
            }
        }
    }
}
