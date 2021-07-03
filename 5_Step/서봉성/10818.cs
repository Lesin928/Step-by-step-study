using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; //정렬될 데이터를 저장하는 배열
            bool repeat; // 반복여부 확인 변수
            string str; // 입력받는 문자열

            do
            {
                // data를 사용자로부터 입력
                Console.WriteLine("10개의 수를 입력받고 작은수에서 큰수로 정렬하기");
                Console.WriteLine("10개의 수를 지시에따라 입력하세요");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}번째 수를 입력하세요:", i + 1);
                    str = Console.ReadLine();
                    array[i] = int.Parse(str);
                }

                // 정렬하는 부분
                for (int i = 0; i < 10; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }

                // 정렬된 data 출력
                Console.WriteLine("입력한 수를 정렬한 결과는 다음과 같습니다.");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} ", array[i]);
                }

                // 반복 여부 확인
                Console.WriteLine("다시 할까요? [1] 다시하기 [2] 끝내기");
                str = Console.ReadLine();
                if (str == "1") repeat = true;
                else repeat = false;
                Console.WriteLine();
            } while (repeat);
        }
    }
}