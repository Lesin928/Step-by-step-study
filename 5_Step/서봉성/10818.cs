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
            int[] array = new int[10]; //���ĵ� �����͸� �����ϴ� �迭
            bool repeat; // �ݺ����� Ȯ�� ����
            string str; // �Է¹޴� ���ڿ�

            do
            {
                // data�� ����ڷκ��� �Է�
                Console.WriteLine("10���� ���� �Է¹ް� ���������� ū���� �����ϱ�");
                Console.WriteLine("10���� ���� ���ÿ����� �Է��ϼ���");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}��° ���� �Է��ϼ���:", i + 1);
                    str = Console.ReadLine();
                    array[i] = int.Parse(str);
                }

                // �����ϴ� �κ�
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

                // ���ĵ� data ���
                Console.WriteLine("�Է��� ���� ������ ����� ������ �����ϴ�.");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0} ", array[i]);
                }

                // �ݺ� ���� Ȯ��
                Console.WriteLine("�ٽ� �ұ��? [1] �ٽ��ϱ� [2] ������");
                str = Console.ReadLine();
                if (str == "1") repeat = true;
                else repeat = false;
                Console.WriteLine();
            } while (repeat);
        }
    }
}