using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Выводить все элементы массива пока не встретится элемент - 1.var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };

            foreach (int i in arrayOfInt)
            {
               if (i == -1)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
