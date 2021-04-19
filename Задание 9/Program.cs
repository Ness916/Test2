using System;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9.Пользователь вводит строку и в ответ ему должно выводиться сколько слов, которые начинаются с заглавной буквы находятся в предложении и также выводятся все эти слова через запятую.Учесть, что таких слов может и не быть.
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();

            string[] text_arr = text.Split(' ');
            string[] result_arr = new string[text_arr.Length];// Создаем массив для записи результата с размером массива введенного через консоль

            int i = 0;

            foreach (var el_arr in text_arr)
            {
                if (Char.IsUpper(el_arr, 0))//Проверяем первый символ в каждом слове
                {
                    result_arr[i] = el_arr; //Если слово начинается с заглавной буквы, записываем его в результат
                    i++;
                }
            }

            int count = 0;
            foreach (var el_arr in result_arr)
            {
                if (el_arr != null)// Проверяем если элемент не пустой
                {
                    if (count == 0)//Выводим первое не пустое значение
                    {
                        Console.Write(el_arr);
                    }
                    else
                    {
                        Console.Write(", " + el_arr);//Выводим последующие значения
                    }
                    count++;
                }
            }
            Console.WriteLine();
            if (count > 0)
            {
                Console.WriteLine($"Всего слов с заглавной буквы {count}");
            }
            else
            {
                Console.WriteLine("Нет слов с заглавной буквы");
            }
        }
    }
}
