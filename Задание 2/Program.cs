using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Расположить все элементы массива в обратном порядке и вывести в консоль, без использования Array.Revers();
            //var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            
            var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            
            for (int i = arrayOfInt.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayOfInt[i]);
            }

        }
    }
}
