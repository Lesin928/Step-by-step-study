using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백준1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                if (a == null)                
                    break;
                string[] AB = a.Split(' ');
                Console.WriteLine(Convert.ToInt32(AB[1]) + Convert.ToInt32(AB[0]));
                

            }
        }
    }
}




