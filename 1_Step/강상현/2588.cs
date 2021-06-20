using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000000022222222
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
      
            string bb = Console.ReadLine();
            char[] B = bb.ToCharArray();

            int[] b = new int[B.Length]; 
            int A = int.Parse(a);

            for (int i = 0; i < B.Length; i++)
            {
                b[i] = int.Parse(B[i].ToString());
            }


            Console.WriteLine(A*b[2]);
            Console.WriteLine(A*b[1]);
            Console.WriteLine(A*b[0]);
            Console.WriteLine(A*b[2]+A*b[1]*10+A*b[0]*100);
        }
    }
}