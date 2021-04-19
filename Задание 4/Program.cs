using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.Необходимо добавить элемент в конец массива и вывести весь массив в консоль.var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };
            var array = new int[] { 0, 1, 3, 67, 5, 2, 1, -4, -1, 99, 111 };

            var array_length = array.Length;
            array_length = array_length + 1;
            Array.Resize(ref array, array_length);
            Console.WriteLine(array);

            foreach (int i in array)
            {
                Console.Write(i+ " ");
            }
        }

        
    }
}
