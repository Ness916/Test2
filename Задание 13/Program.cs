using System;
using System.Text.RegularExpressions;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)

            //1. Убрать все спец.символы в словах массива.
            //2. Заменить все нули на о, убрать все цифры, убрать все лишние пробелы.
            //3. Собрать из всех полученых слов предложение и вывести в консоль.
        {
            var array = new[, ,]
            {
                {
                    { "(((&Y@#06u%^&", "m6u%$^s!t", " t0" },
                    { "k@!!^n0!@w", "?*()h0&&w", "!t#$!0*" },
                    { " !@#w0)(r&*(&k ", "&*w*i6t^h%", "a@#$r$$$$r@ay#%s" },
                    { "!@a@!##@n!@#!@d##", "w*i6t^h%", "!@#!$%$c!@#!y^&*^&*c$%^l$%^e$%^s!#@!@" }
                }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = Regex.Replace(array[i, j, k], @"[^\w\r\n]", string.Empty);
                        array[i, j, k] = Regex.Replace(array[i, j, k], "0", "o");
                        array[i, j, k] = Regex.Replace(array[i, j, k], @"[0-9\-]", string.Empty);
                        Console.Write(String.Format("{0,3}", array[i, j, k]));

                    }
                }
            }

        }
    }
}