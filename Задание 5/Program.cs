using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Необходимо добавить элемент в начало массива и вывести весь массив в консоль. var array = new int[]{ 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };

            var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };

            var array_length = array.Length;
            array_length = array_length + 1;
            Array.Resize(ref array, array_length);
            array[array_length - 1] = 10;

            int temp = 0;
            int temp_2 = 0;
            temp = array[0];
            array[0] = array[array_length - 1];

            for (int i = 1; i < array_length; i++)
            {
                if (i % 2 != 0)
                {
                    temp_2 = array[i];// в temp_2 записываем значение массива
                    array[i] = temp;// значению массиву i присваеваем значение, которое хранилось в переменной temp

                }
                else
                {
                    temp = array[i];
                    array[i] = temp_2;
                }
            }

            foreach (int el_arr in array)
            {
                Console.Write(el_arr + " ");
            }

        }
    }
}
