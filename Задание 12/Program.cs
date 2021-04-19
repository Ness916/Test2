using System;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //12. Создать двумерный массив 5х5. Заполнить рандомными значениями от 0 до 20. НЕ показывать пользоветелю. Спрашивать по одному числу у пользователя, если введенное число есть в массиве -выводить как на картинке: http://prntscr.com/10drjzz
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите число от 0 до 20:");
            int zn = Convert.ToInt32(Console.ReadLine());

            int n = 5;
            int m = 5;
            int[,] mas = new int[n, m];
            Random rn = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = rn.Next(20);
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mas[i, j] == zn)
                    {
                        Console.Write(String.Format("{0,3}", mas[i, j]));
                    }
                    else
                    {
                        Console.Write(String.Format("{0,3}", "*"));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

