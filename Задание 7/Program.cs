using System;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывести двумерный массив в консоль, чтобы элементы рассполагались в виде матрицы(могу показать пример).var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };

            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };
            

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(String.Format("{0,3}", array[i, j]));
                }
                Console.WriteLine();
            }
        }

       
    }
}
