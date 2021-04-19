using System;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Вывести двумерный массив в консоль, чтобы элементы рассполагались в виде матрицы, негативные цифры не должны выводиться.var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };

            var array = new int[,]
            { 
                { 1, 2, -1, 4 }, 
                { 1, -2, 1, 4 }, 
                { 1, 5, -1, 4 }, 
                { 1, 2, -1, 4 } 
            };

            for (int i = 0; i < array.GetLength(0); i++)// строки
            {
                for (int j = 0; j < array.GetLength(1); j++)// столбцы
                {
                    if (array[i, j] >= 0)
                    {
                        Console.Write(String.Format("{0,3}", array[i, j]));
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
