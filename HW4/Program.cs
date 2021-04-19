using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var arrayOfInt = new int[] { 0, 7, 3, 4, 5, 6, -1, 8, 9 };
            
            foreach (int i in arrayOfInt)
            {
                Console.WriteLine($"Вывод foreach: {i}");
            }

            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                Console.WriteLine($"Вывод for: {arrayOfInt[i]}");
            }


            int j = 0;
            while (j < arrayOfInt.Length)
            {
                Console.WriteLine($"Вывод while: {arrayOfInt[j]}");
                j++;
            }

            int k = 0;
            do
            {
                Console.WriteLine($"Вывод do: {arrayOfInt[k]}");
                k++;
            }
              while (k < arrayOfInt.Length);
        }
    }
}
