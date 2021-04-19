using System;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10.Пользователь вводит 6 своих последних зарплат, ему выводится максимальная, минимальная, средняя зп и общая сумма.Использовать массивы и циклы. Запрещено использовать LINQ.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int[] arr_zp = new int[6];
            Console.WriteLine("Введите первое значение:");
            arr_zp[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе значение:");
            arr_zp[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье значение:");
            arr_zp[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое значение:");
            arr_zp[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пятое значение:");
            arr_zp[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шестое значение:");
            arr_zp[5] = Convert.ToInt32(Console.ReadLine());

            int temp; //сортировка массива от большего к меньшему
            for (int i = 0; i < arr_zp.Length - 1; i++)
            {
                for (int j = i + 1; j < arr_zp.Length; j++)
                {
                    if (arr_zp[i] > arr_zp[j])
                    {
                        temp = arr_zp[i];
                        arr_zp[i] = arr_zp[j];
                        arr_zp[j] = temp;
                    }
                }
            }

            Console.WriteLine($"Максимальоное значение {arr_zp[5]}");
            Console.WriteLine($"Минимальоное значение {arr_zp[0]}");

            int sum_zp = 0;
            for (int i = 0; i < arr_zp.Length; i++)
            {
                sum_zp = sum_zp + arr_zp[i];
            }
            Console.WriteLine($"Сумма {sum_zp}");
            Console.WriteLine($"Средняя {sum_zp / 6}");
        }
    }
}
