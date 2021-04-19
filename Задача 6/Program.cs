using System;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. Вывести сумму всех чисел двумерного массива, нужно использовать циклы. var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };

            var array = new int[,] { { 1, 2, -1, 4 }, { 1, -2, 1, 4 }, { 1, 5, -1, 4 }, { 1, 2, -1, 4 } };

            int k = 0;
            
            foreach (int i in array)
            {
                k = k + i;
            }
            Console.WriteLine(k);

        } 
    }
    }

