using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4344
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = int.Parse(Console.ReadLine());
			string[] nums = new string[a];
			int aver=0;
			int k,high=0;
			float result=0;
			for (int i=0;i<a;i++)
            {
				nums[i] = Console.ReadLine();
			}
			for(int j=0;j<a;j++)
            {
				string[] stud = nums[j].Split();
				int[] score = new int[int.Parse(stud[0])+1];
				for (k = 0; k < int.Parse(stud[0])+1; k++)
				{
					score[k] = Convert.ToInt32(stud[k]);
					aver = aver + score[k];
				}
				aver = (aver-score[0]) / score[0];
				for (k = 1; k < int.Parse(stud[0])+1; k++)
				{
					if(score[k]>aver)
                    {
						high++;
                    }
				}
				result = (float)high / (float)score[0] * 100;
				Console.WriteLine("{0:f3}%",result);
				aver = 0;
				high = 0;
			}
		}
    }
}
